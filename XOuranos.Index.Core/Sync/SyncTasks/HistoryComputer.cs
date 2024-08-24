using System.Threading.Tasks;
using XOuranos.Index.Core.Extensions;
using XOuranos.Index.Core.Settings;
using XOuranos.Index.Core.Storage;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace XOuranos.Index.Core.Sync.SyncTasks;

public class HistoryComputer : TaskRunner
{
   readonly ILogger<HistoryComputer> logger;
   readonly IStorage storage;
   readonly IComputeHistoryQueue computeHistoryQueue;
   readonly IndexerSettings indexerSettings;

   public HistoryComputer(IOptions<IndexerSettings> configuration, ILogger<HistoryComputer> logger, IStorage storage,
      IComputeHistoryQueue computeHistoryQueue, IOptions<IndexerSettings> indexerSettings) : base(configuration, logger)
   {
      this.logger = logger;
      this.storage = storage;
      this.computeHistoryQueue = computeHistoryQueue;
      this.indexerSettings = indexerSettings.Value;
   }

   public override async Task<bool> OnExecute()
   {
      if (indexerSettings.MaxItemsInHistoryQueue <= 0)
         return true;

      if (StopRunnerExecution)
      {
         return false;
      }

      var stopwatch = Stopwatch.Start();

      int addressesCount = 0;

      do
      {
         if (!computeHistoryQueue.GetNextItemFromQueue(out string address))
         {
            stopwatch.Stop();
            return await Task.FromResult(false);
         }

         storage.AddressBalance(address);

         addressesCount++;

         if (StopRunnerExecution)
            break;
      } while (!computeHistoryQueue.IsQueueEmpty() && !CancellationToken.IsCancellationRequested && !Abort);

      stopwatch.Stop();

      logger.Log(LogLevel.Information,$"Runner for computed history completed in {stopwatch.Elapsed} and processed {addressesCount} addresses");

      return await Task.FromResult(true);
   }

   private bool StopRunnerExecution => Runner.GlobalState.IndexMode ||
                              Runner.GlobalState.ReorgMode ||
                              Runner.GlobalState.IbdMode();

}
