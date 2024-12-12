using Blockcore.Index.Core.Storage.Types;

namespace Blockcore.Index.Core.Storage.Mongo.Types;

public class UnspentOutputTable
{
   public Outpoint Outpoint { get; set; }

   public string Address { get; set; }

   public long Value { get; set; }

   public uint BlockIndex { get; set; }
}
