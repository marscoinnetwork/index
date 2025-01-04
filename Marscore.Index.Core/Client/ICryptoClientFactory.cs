using Marscore.Index.Core.Operations.Types;

namespace Marscore.Index.Core.Client
{
   public interface ICryptoClientFactory
   {
      IBlockchainClient Create(SyncConnection connection);
   }
}
