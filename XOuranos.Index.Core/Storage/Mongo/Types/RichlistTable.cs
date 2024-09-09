using MongoDB.Bson.Serialization.Attributes;

namespace XOuranos.Index.Core.Storage.Mongo.Types
{
  public class RichlistTable
   {
      //[BsonId]
      public object _id { get; set; }
      public string Address { get; set; }
      public long Balance { get; set; }
   }
}
