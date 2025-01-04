using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Marscore.Index.Core.Client;
using Marscore.Index.Core.Operations;
using Marscore.Index.Core.Operations.Types;
using Marscore.Index.Core.Storage;
using Microsoft.Extensions.Logging;
using Marscore.Consensus.TransactionInfo;

namespace Marscore.Index.Core.Handlers
{
   /// <summary>
   /// Handler to make get info about a blockchain.
   /// </summary>
   public class CommandHandler
   {
      private readonly SyncConnection syncConnection;

      private readonly IStorageOperations storageOperations;
      readonly ICryptoClientFactory clientFactory;
      private readonly ILogger<CommandHandler> log;

      /// <summary>
      /// Initializes a new instance of the <see cref="StatsHandler"/> class.
      /// </summary>
      public CommandHandler(SyncConnection connection, ILogger<CommandHandler> logger, IStorageOperations storageOperations, ICryptoClientFactory clientFactory)
      {
         log = logger;
         this.storageOperations = storageOperations;
         this.clientFactory = clientFactory;
         syncConnection = connection;
      }

      public async Task<string> SendTransaction(string transactionHex)
      {
         // todo: consider adding support for retries.
         // todo: check how a failure is porpageted

         SyncConnection connection = syncConnection;
         Transaction trx = null;

         // parse the trx;
         trx = connection.Network.Consensus.ConsensusFactory.CreateTransaction(transactionHex);
         trx.PrecomputeHash(false, true);

         IBlockchainClient client = clientFactory.Create(connection);
         string trxid = await client.SentRawTransactionAsync(transactionHex);

         if (trx.GetHash().ToString() != trxid)
         {
            throw new Exception($"node trxid = {trxid}, serialized trxid = {trx.GetHash().ToString()}");
         }

         storageOperations.InsertMempoolTransactions(new SyncBlockTransactionsOperation
         {
            Transactions = new List<Transaction> { trx }
         });

         return trxid;
      }
   }
}
