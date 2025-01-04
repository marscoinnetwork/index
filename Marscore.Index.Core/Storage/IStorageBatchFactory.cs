using Marscore.Index.Core.Operations.Types;

namespace Marscore.Index.Core.Storage;

public interface IStorageBatchFactory
{
   StorageBatch GetStorageBatch();
}
