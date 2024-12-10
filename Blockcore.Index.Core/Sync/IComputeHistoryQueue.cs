namespace Blockcore.Index.Core.Sync;

public interface IComputeHistoryQueue
{
   bool IsQueueEmpty();
   void AddAddressToComputeHistoryQueue(string address);
   bool GetNextItemFromQueue(out string address);
}
