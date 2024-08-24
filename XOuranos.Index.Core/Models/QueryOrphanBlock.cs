using System;
using XOuranos.Index.Core.Storage.Types;

namespace XOuranos.Index.Core.Models
{
   public class QueryOrphanBlock
   {
      public DateTime Created { get; set; }
      public uint BlockIndex { get; set; }
      public string BlockHash { get; set; }
      public QueryBlock Block { get; set; }
   }
}
