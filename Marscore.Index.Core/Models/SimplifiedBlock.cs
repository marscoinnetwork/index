
namespace Marscore.Index.Core.Models;

public class SimplifiedBlock
{
    public long Height { get; set; }
    public long Size { get; set; }
    public long Weight { get; set; }
    public BlockType ProofType { get; set; }
    public long Time { get; set; }
    public long MedianTime { get; set; }

    public long TxCount { get; set; }
}