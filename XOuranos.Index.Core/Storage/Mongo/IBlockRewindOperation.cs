using System.Threading.Tasks;

namespace XOuranos.Index.Core.Storage.Mongo;

public interface IBlockRewindOperation
{
   Task RewindBlockAsync(uint blockIndex);
}
