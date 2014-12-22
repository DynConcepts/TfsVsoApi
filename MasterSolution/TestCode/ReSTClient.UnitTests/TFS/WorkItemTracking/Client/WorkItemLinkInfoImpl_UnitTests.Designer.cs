using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkInfoImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemLinkInfoImpl> GetIEnumerableInstance() { return new List<WorkItemLinkInfoImpl> {GetInstance()}; }

        internal static WorkItemLinkInfoImpl GetInstance([CallerMemberName] string callerName = "")
        {
            WorkItemLinkInfoImpl instance = default(WorkItemLinkInfoImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkInfoImpl instance, [CallerMemberName] string callerName = "");
    }
}