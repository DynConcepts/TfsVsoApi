using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemIdImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemIdImpl> GetIEnumerableInstance() { return new List<WorkItemIdImpl> {GetInstance()}; }

        internal static WorkItemIdImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemIdImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemIdImpl instance, [CallerMemberName] string callerName = "");
    }
}