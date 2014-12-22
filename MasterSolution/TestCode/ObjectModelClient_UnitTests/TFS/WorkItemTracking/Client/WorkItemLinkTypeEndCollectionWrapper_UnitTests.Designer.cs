using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkTypeEndCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemLinkTypeEndCollectionWrapper> GetIEnumerableInstance() { return new List<WorkItemLinkTypeEndCollectionWrapper> {GetInstance()}; }

        internal static WorkItemLinkTypeEndCollectionWrapper GetInstance()
        {
            WorkItemLinkTypeEndCollection real = default(WorkItemLinkTypeEndCollection);
            RealInstanceFactory(ref real);
            var instance = (WorkItemLinkTypeEndCollectionWrapper) WorkItemLinkTypeEndCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkTypeEndCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemLinkTypeEndCollection real, [CallerMemberName] string callerName = "");
    }
}