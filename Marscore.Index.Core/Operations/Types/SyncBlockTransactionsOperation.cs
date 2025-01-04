using Marscore.Consensus.TransactionInfo;
using System.Collections.Generic;
using Marscore.Index.Core.Client.Types;

namespace Marscore.Index.Core.Operations.Types
{
   /// <summary>
   /// The sync block info.
   /// </summary>
   public class SyncBlockTransactionsOperation
   {
      /// <summary>
      /// Gets or sets the block info.
      /// </summary>
      public BlockInfo BlockInfo { get; set; }

      /// <summary>
      /// Gets or sets the transactions.
      /// </summary>
      public IEnumerable<Transaction> Transactions { get; set; }
   }
}
