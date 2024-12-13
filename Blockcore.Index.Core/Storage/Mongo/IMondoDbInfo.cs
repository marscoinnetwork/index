using System.Collections.Generic;
using Blockcore.Index.Core.Storage.Mongo.Types;

namespace Blockcore.Index.Core.Storage.Mongo;

public interface IMondoDbInfo
{
   public List<IndexView> GetIndexesBuildProgress();
}
