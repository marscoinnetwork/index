using XOuranos.Index.Core.Client.Types;
using XOuranos.Index.Core.Storage.Mongo.Types;
using XOuranos.Index.Core.Storage.Types;

namespace XOuranos.Index.Core.Storage.Mongo
{
   public interface IMapMongoBlockToStorageBlock
   {
      SyncBlockInfo Map(BlockTable block);
      BlockTable Map(BlockInfo blockInfo);
   }
}
