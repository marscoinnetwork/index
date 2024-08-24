using XOuranos.Index.Core.Operations.Types;

namespace XOuranos.Index.Core.Storage;

public interface IStorageBatchFactory
{
   StorageBatch GetStorageBatch();
}
