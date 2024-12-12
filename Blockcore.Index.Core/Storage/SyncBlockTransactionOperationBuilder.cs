
using Blockcore.Consensus.BlockInfo;
using Blockcore.Index.Core.Client.Types;
using Blockcore.Index.Core.Operations.Types;

namespace Blockcore.Index.Core.Storage
{
   public class SyncBlockTransactionOperationBuilder : ISyncBlockTransactionOperationBuilder
   {

      public SyncBlockTransactionsOperation BuildFromClientData(BlockInfo blockInfo, Block block)
      {
         return new SyncBlockTransactionsOperation { BlockInfo = blockInfo, Transactions = block.Transactions };
      }
   }
}
