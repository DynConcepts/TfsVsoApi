using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkInfoWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemLinkInfoWrapper> GetIEnumerableInstance() { return new List<WorkItemLinkInfoWrapper> {GetInstance()}; }

        internal static WorkItemLinkInfoWrapper GetInstance()
        {
            var real = new WorkItemLinkInfo();
            RealInstanceFactory(ref real);
            var instance = (WorkItemLinkInfoWrapper) WorkItemLinkInfoWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkInfoWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemLinkInfo real, [CallerMemberName] string callerName = "");
    }
}