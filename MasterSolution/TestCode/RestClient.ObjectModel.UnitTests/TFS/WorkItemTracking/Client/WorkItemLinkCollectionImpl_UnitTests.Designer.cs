using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkCollectionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AddedLinks_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkCollection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AddedLinks; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DeletedLinks_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkCollection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DeletedLinks; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AddedLinks_SetCondition(ref IWorkItemLinkCollection instance, ref IEnumerable<IWorkItemLink> setValue);
        partial void DeletedLinks_SetCondition(ref IWorkItemLinkCollection instance, ref IEnumerable<IWorkItemLink> setValue);
        internal static IEnumerable<WorkItemLinkCollectionImpl> GetIEnumerableInstance() { return new List<WorkItemLinkCollectionImpl> {GetInstance()}; }

        internal static WorkItemLinkCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            WorkItemLinkCollectionImpl instance = WorkItemLinkCollectionImpl.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkCollectionImpl instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);
    }
}