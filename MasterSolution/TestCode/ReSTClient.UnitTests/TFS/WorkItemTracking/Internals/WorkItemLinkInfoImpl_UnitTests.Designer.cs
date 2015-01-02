using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkInfoImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemLinkInfoImpl> GetIEnumerableInstance() { return new List<WorkItemLinkInfoImpl> {GetInstance()}; }

        internal static WorkItemLinkInfoImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemLinkInfoImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkInfoImpl instance, [CallerMemberName] string callerName = "");
    }
}