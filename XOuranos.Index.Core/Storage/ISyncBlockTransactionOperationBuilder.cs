using XOuranos.Consensus.BlockInfo;
using XOuranos.Index.Core.Client.Types;
using XOuranos.Index.Core.Operations.Types;

namespace XOuranos.Index.Core.Storage
{
   public interface ISyncBlockTransactionOperationBuilder
   {
      SyncBlockTransactionsOperation BuildFromClientData(BlockInfo blockInfo, Block block);
   }
}
