using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blockcore.Index.Core.Client.Types;
using Blockcore.Index.Core.Handlers;
using Blockcore.Index.Core.Models;
using Blockcore.Index.Core.Storage;
using Microsoft.AspNetCore.Mvc;

namespace Blockcore.Index.Core.Controllers
{
   /// <summary>
   /// Controller to get some information about a coin.
   /// </summary>
   [ApiController]
   [Route("api/stats")]
   public class StatsController : ControllerBase
   {
      private readonly StatsHandler statsHandler;

      private readonly IStorage storage;

      /// <summary>
      /// Initializes a new instance of the <see cref="StatsController"/> class.
      /// </summary>
      public StatsController(StatsHandler statsHandler, IStorage storage)
      {
         this.statsHandler = statsHandler;
         this.storage = storage;
      }

      [HttpGet]
      [Route("heartbeat")]
      public IActionResult Heartbeat()
      {
         return Ok("Heartbeat");
      }

      [HttpGet]
      [Route("connections")]
      public async Task<IActionResult> Connections()
      {
         StatsConnection ret = await statsHandler.StatsConnection();
         return Ok(ret);
      }

      [HttpGet()]
      public async Task<IActionResult> Get()
      {
         Statistics ret = await statsHandler.Statistics();
         return Ok(ret);
      }

        [HttpGet]
        [Route("getblockchaininfo")]
        public async Task<IActionResult> GetInfo()
        {
            Statistics ret = await statsHandler.Statistics();
            var info = new GetBlockchainInfoResult() {
                Chain="main",
                Blocks=ret.Blockchain.Blocks,
                Moneysupply=0,
                Moneysupply_formatted="0",
                Zerocoinsupply=new List<ZerocoinSupply>() { },
                Headers=ret.Blockchain.Blocks,
                Bestblockhash=ret.Blockchain.BestBlockHash,
                Difficulty_pow=ret.Blockchain.Difficulty,
                Difficulty_randomx=ret.Blockchain.Difficulty,
                Difficulty_progpow=ret.Blockchain.Difficulty,
                Difficulty_sha256d=ret.Blockchain.Difficulty,
                Difficulty_pos=ret.Blockchain.NetworkWeight,
                Mediantime=(ulong)ret.Blockchain.MedianTime,
                verificationprogress=ret.Blockchain.VerificationProgress,
                initialblockdownload=ret.Blockchain.IsInitialBlockDownload,
                chainwork=ret.Blockchain.Chainwork,
                chainpow=ret.Blockchain.Chainwork,
                Size_on_disk=0,
                pruned=ret.Blockchain.IsPruned,
                bip9_softforks=new Dictionary<string, Softfork>() {},
                warnings="",
                Next_super_block=0
            };
            info.bip9_softforks.Add("zc_limp", new Softfork() {
                status="active",
                startTime=0,
            });
            return Ok(info);
        }

        [HttpGet]
        [Route("getchainalgostats")]
        public async Task<IActionResult> GetStats()
        {
            Statistics ret = await statsHandler.Statistics();
            var info = new GetChainalgoStats();
            info.Result = new GetChainalgoStatsResult() {
            };
            return Ok(info);
        }

        /// <summary>
        /// Returns a lot of information about the network, node and consensus rules.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
      [Route("info")]
      public async Task<IActionResult> Info()
      {
         CoinInfo ret = await statsHandler.CoinInformation();
         return Ok(ret);
      }

      /// <summary>
      /// Returns a list of currently connected nodes.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      [Route("peers")]
      public async Task<IActionResult> Peers()
      {
         System.Collections.Generic.List<Client.Types.PeerInfo> ret = await statsHandler.Peers();
         return Ok(ret);
      }

      /// <summary>
      /// Returns a list of nodes observed after the date supplied in the URL.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      [Route("peers/{date}")]
      public IActionResult Peers(DateTime date)
      {
         List<PeerInfo> list = storage.GetPeerFromDate(date)
            .Select(x => x as PeerInfo)
            .ToList();
         return Ok(list);
      }

      /// <summary>
      /// Returns fee rate estimations for each of the confirmations in the array.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      [Route("fee")]
      public async Task<IActionResult> FeeEstimation([FromQuery] int[] confirmations)
      {
         var res = await statsHandler.GetFeeEstimation(confirmations);

         return Ok(res);
      }
   }
}
