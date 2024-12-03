using System.Collections.Generic;

namespace Blockcore.Index.Core.Models;

public class QueryBlockResults
{
   public IEnumerable<QueryBlock> Blocks { get; set; }

   public int Total { get; set; }
}
