using System.Threading.Tasks;

namespace Marscore.Index.Core.Storage.Mongo;

public interface IBlockRewindOperation
{
   Task RewindBlockAsync(uint blockIndex);
}
