using Marscore.NBitcoin;
using Newtonsoft.Json;

namespace Marscore.Index.Core.Client.Types
{
   public class EstimateSmartFeeResponse
	{

      [JsonProperty("feeRate")]
      public string FeeRateInfo
		{
			get; set;
		}

      [JsonProperty("blocks")]
      public int Blocks
		{
			get; set;
		}

      [JsonIgnore()]
      public FeeRate FeeRate
      {
         get
         {
            return new FeeRate(Money.Parse(FeeRateInfo));

         }
         set
         {
            FeeRateInfo = FeeRate.ToString();
         }
      }
   }
}
