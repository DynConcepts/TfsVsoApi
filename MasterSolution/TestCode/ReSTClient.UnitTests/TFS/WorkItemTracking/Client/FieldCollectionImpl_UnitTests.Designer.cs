using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class FieldCollectionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DropCachedData_UnitTest()
        {
            ExecuteMethod(
                () => { return (IFieldCollection) GetInstance(); },
                instance => { DropCachedData_PreCondition(ref instance); },
                instance => { instance.DropCachedData(); },
                instance => { DropCachedData_PostValidate(instance); });
        }

        partial void DropCachedData_PostValidate(IFieldCollection instance);
        partial void DropCachedData_PreCondition(ref IFieldCollection instance);
        internal static IEnumerable<FieldCollectionImpl> GetIEnumerableInstance() { return new List<FieldCollectionImpl> {GetInstance()}; }

        internal static FieldCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            FieldCollectionImpl instance = FieldCollectionImpl.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref FieldCollectionImpl instance, [CallerMemberName] string callerName = "");

        static partial void JsonSource(ref JToken json);
    }
}