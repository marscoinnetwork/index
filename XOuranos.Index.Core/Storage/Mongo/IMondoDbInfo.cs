using System.Collections.Generic;
using XOuranos.Index.Core.Storage.Mongo.Types;

namespace XOuranos.Index.Core.Storage.Mongo;

public interface IMondoDbInfo
{
   public List<IndexView> GetIndexesBuildProgress();
}
