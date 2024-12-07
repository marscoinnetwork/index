using Blockcore.Index.Core.Operations.Types;

namespace Blockcore.Index.Core.Storage;

public interface IStorageBatchFactory
{
   StorageBatch GetStorageBatch();
}
