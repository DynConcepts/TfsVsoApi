using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemImpl_UnitTests
    {
        /// <summary>
        ///     Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context) { var api = new JsonWitAPI(); }

        static partial void InstanceFactory(ref WorkItemImpl instance, string callerName)
        {
            if (callerName == "Revisions_UnitTest")
            {
                instance = JsonWorkItem.APIFactory().GetWorkItem(95, WorkItemImpl.FromToken).Result;
            }
        }

        static partial void JsonSource(ref JToken json)
        {
            var retVal = new JObject();
            retVal.Add("id", "123456");
            retVal.Add("rev", "1");
            json = retVal;
        }
    }
}