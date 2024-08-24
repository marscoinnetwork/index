using XOuranos.Index.Core.Operations.Types;
using XOuranos.Index.Core.Storage.Types;

namespace XOuranos.Index.Core.Operations
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
