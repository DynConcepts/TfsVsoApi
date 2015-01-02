using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IWorkItemRowSetsImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IWorkItemRowSetsImpl> GetIEnumerableInstance() { return new List<IWorkItemRowSetsImpl> {GetInstance()}; }

        internal static IWorkItemRowSetsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IWorkItemRowSetsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IWorkItemRowSetsImpl instance, [CallerMemberName] string callerName = "");
    }
}