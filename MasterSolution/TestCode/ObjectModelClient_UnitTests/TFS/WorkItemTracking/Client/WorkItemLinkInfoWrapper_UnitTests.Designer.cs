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
    public partial class WorkItemLinkInfoWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemLinkInfoWrapper> GetIEnumerableInstance() { return new List<WorkItemLinkInfoWrapper> {GetInstance()}; }

        internal static WorkItemLinkInfoWrapper GetInstance()
        {
            WorkItemLinkInfo real = default(WorkItemLinkInfo);
            RealInstanceFactory(ref real);
            WorkItemLinkInfoWrapper instance = WorkItemLinkInfoWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkInfoWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemLinkInfo real, [CallerMemberName] string callerName = "");
    }
}