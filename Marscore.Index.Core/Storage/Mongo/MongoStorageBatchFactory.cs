using Marscore.Index.Core.Operations.Types;
using Marscore.Index.Core.Storage.Mongo.Types;

namespace Marscore.Index.Core.Storage.Mongo;

public class MongoStorageBatchFactory : IStorageBatchFactory
{
   public StorageBatch GetStorageBatch() => new MongoStorageBatch();
}
