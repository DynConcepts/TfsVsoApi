using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonLinkTypeEnd_UnitTests : DynTestClassBase
    {
        static partial void InstanceFactory(ref JsonLinkTypeEnd instance, string callerName)
        {
            var token = new JObject();
            instance = JsonLinkTypeEnd.FromToken(token);
        }
    }
}