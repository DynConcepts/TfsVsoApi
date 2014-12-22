using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkCollectionWrapper_UnitTests : DynTestClassBase
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
        internal static IEnumerable<WorkItemLinkCollectionWrapper> GetIEnumerableInstance() { return new List<WorkItemLinkCollectionWrapper> {GetInstance()}; }

        internal static WorkItemLinkCollectionWrapper GetInstance()
        {
            WorkItemLinkCollection real = default(WorkItemLinkCollection);
            RealInstanceFactory(ref real);
            var instance = (WorkItemLinkCollectionWrapper) WorkItemLinkCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkCollectionWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref WorkItemLinkCollection real, [CallerMemberName] string callerName = "");
    }
}