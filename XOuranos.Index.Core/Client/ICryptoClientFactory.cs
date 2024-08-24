using XOuranos.Index.Core.Operations.Types;

namespace XOuranos.Index.Core.Client
{
   public interface ICryptoClientFactory
   {
      IBlockchainClient Create(SyncConnection connection);
   }
}
