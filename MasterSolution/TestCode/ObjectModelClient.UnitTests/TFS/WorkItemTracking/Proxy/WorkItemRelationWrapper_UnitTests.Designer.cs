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
    public partial class WorkItemRelationWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemRelationWrapper> GetIEnumerableInstance() { return new List<WorkItemRelationWrapper> {GetInstance()}; }

        internal static WorkItemRelationWrapper GetInstance()
        {
            WorkItemRelation real = default(WorkItemRelation);
            RealInstanceFactory(ref real);
            WorkItemRelationWrapper instance = WorkItemRelationWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemRelationWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemRelation real, [CallerMemberName] string callerName = "");
    }
}