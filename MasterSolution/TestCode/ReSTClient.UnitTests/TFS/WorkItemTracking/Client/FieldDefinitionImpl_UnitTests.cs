using System.Runtime.InteropServices.WindowsRuntime;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class FieldDefinitionImpl_UnitTests
  {

      static partial void JsonSource(ref JToken json)
      {
          JObject retVal = new JObject();
          retVal.Add("referenceName", "Testing.Field.ReferenceName");
          retVal.Add("rel", "Testing.Field.Rel");
          json = retVal;
      }

  }
}
