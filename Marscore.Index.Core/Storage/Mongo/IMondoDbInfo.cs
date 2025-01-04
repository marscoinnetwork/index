using System.Collections.Generic;
using Marscore.Index.Core.Storage.Mongo.Types;

namespace Marscore.Index.Core.Storage.Mongo;

public interface IMondoDbInfo
{
   public List<IndexView> GetIndexesBuildProgress();
}
