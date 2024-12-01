using Blockcore.Index.Core.Operations.Types;

namespace Blockcore.Index.Core.Client
{
   public interface ICryptoClientFactory
   {
      IBlockchainClient Create(SyncConnection connection);
   }
}
