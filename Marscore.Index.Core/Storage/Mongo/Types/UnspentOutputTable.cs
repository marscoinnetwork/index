using Marscore.Index.Core.Storage.Types;

namespace Marscore.Index.Core.Storage.Mongo.Types;

public class UnspentOutputTable
{
   public Outpoint Outpoint { get; set; }

   public string Address { get; set; }

   public long Value { get; set; }

   public uint BlockIndex { get; set; }
}
