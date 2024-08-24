using XOuranos.Consensus.BlockInfo;
using XOuranos.Index.Core.Client.Types;
using XOuranos.Index.Core.Operations.Types;

namespace XOuranos.Index.Core.Storage
{
   public class SyncBlockTransactionOperationBuilder : ISyncBlockTransactionOperationBuilder
   {

      public SyncBlockTransactionsOperation BuildFromClientData(BlockInfo blockInfo, Block block)
      {
         return new SyncBlockTransactionsOperation { BlockInfo = blockInfo, Transactions = block.Transactions };
      }
   }
}
