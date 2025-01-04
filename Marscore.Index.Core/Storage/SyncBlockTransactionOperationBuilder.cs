
using Marscore.Consensus.BlockInfo;
using Marscore.Index.Core.Client.Types;
using Marscore.Index.Core.Operations.Types;

namespace Marscore.Index.Core.Storage
{
   public class SyncBlockTransactionOperationBuilder : ISyncBlockTransactionOperationBuilder
   {

      public SyncBlockTransactionsOperation BuildFromClientData(BlockInfo blockInfo, Block block)
      {
         return new SyncBlockTransactionsOperation { BlockInfo = blockInfo, Transactions = block.Transactions };
      }
   }
}
