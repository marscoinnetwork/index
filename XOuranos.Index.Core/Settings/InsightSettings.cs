using System.Collections.Generic;
using XOuranos.Index.Core.Models;

namespace XOuranos.Index.Core.Settings
{
   public class InsightSettings
   {
      public InsightSettings()
      {
         Wallets = new List<Wallet>();
      }

      public List<Wallet> Wallets { get; set; }

      public List<RewardModel> Rewards { get; set; }
   }
}
