using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemRelationImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemRelationImpl> GetIEnumerableInstance() { return new List<WorkItemRelationImpl> {GetInstance()}; }

        internal static WorkItemRelationImpl GetInstance([CallerMemberName] string callerName = "")
        {
            WorkItemRelationImpl instance = default(WorkItemRelationImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemRelationImpl instance, [CallerMemberName] string callerName = "");
    }
}