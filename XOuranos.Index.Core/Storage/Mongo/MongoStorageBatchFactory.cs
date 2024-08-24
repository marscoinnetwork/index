using XOuranos.Index.Core.Operations.Types;
using XOuranos.Index.Core.Storage.Mongo.Types;

namespace XOuranos.Index.Core.Storage.Mongo;

public class MongoStorageBatchFactory : IStorageBatchFactory
{
   public StorageBatch GetStorageBatch() => new MongoStorageBatch();
}
