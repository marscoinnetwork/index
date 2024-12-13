using Blockcore.Index.Core.Client.Types;
using Blockcore.Index.Core.Storage.Mongo.Types;
using Blockcore.Index.Core.Storage.Types;
using MongoDB.Driver;

namespace Blockcore.Index.Core.Storage.Mongo;

public interface IMongoDb
{
   IMongoCollection<OutputTable> OutputTable { get; }
   IMongoCollection<InputTable> InputTable { get; }
   IMongoCollection<UnspentOutputTable> UnspentOutputTable { get; }
   IMongoCollection<AddressComputedTable> AddressComputedTable { get; }
   IMongoCollection<AddressHistoryComputedTable> AddressHistoryComputedTable { get; }
   IMongoCollection<TransactionBlockTable> TransactionBlockTable { get; }
   IMongoCollection<TransactionTable> TransactionTable { get; }
   IMongoCollection<BlockTable> BlockTable { get; }
   IMongoCollection<RichlistTable> RichlistTable { get; }
   IMongoCollection<PeerDetails> Peer { get; }
   IMongoCollection<MempoolTable> Mempool { get; }
   IMongoCollection<ReorgBlockTable> ReorgBlock { get; }
}
