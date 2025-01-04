
using Marscore.Consensus.BlockInfo;
using Marscore.Index.Core.Client.Types;
using Marscore.Index.Core.Operations.Types;

namespace Marscore.Index.Core.Storage
{
   public interface ISyncBlockTransactionOperationBuilder
   {
      SyncBlockTransactionsOperation BuildFromClientData(BlockInfo blockInfo, Block block);
   }
}
