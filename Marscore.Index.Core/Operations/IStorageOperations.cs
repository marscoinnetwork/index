using Marscore.Index.Core.Operations.Types;
using Marscore.Index.Core.Storage.Types;

namespace Marscore.Index.Core.Operations
{
   /// <summary>
   /// The StorageOperations interface.
   /// </summary>
   public interface IStorageOperations
   {

      void AddToStorageBatch(StorageBatch storageBatch, SyncBlockTransactionsOperation item);

      SyncBlockInfo PushStorageBatch(StorageBatch storageBatch);

      void InsertMempoolTransactions(SyncBlockTransactionsOperation item);
   }
}
