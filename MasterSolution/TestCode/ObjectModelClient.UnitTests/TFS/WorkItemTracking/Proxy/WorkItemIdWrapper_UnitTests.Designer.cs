using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemIdWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemIdWrapper> GetIEnumerableInstance() { return new List<WorkItemIdWrapper> {GetInstance()}; }

        internal static WorkItemIdWrapper GetInstance()
        {
            WorkItemId real = default(WorkItemId);
            RealInstanceFactory(ref real);
            var instance = (WorkItemIdWrapper) WorkItemIdWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemIdWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemId real, [CallerMemberName] string callerName = "");
    }
}