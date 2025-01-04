using Marscore.Index.Core.Client.Types;
using Marscore.Index.Core.Storage.Mongo.Types;
using Marscore.Index.Core.Storage.Types;

namespace Marscore.Index.Core.Storage.Mongo
{
   public interface IMapMongoBlockToStorageBlock
   {
      SyncBlockInfo Map(BlockTable block);
      BlockTable Map(BlockInfo blockInfo);
   }
}
