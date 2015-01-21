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
    public partial class IWorkItemRowSetsWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IWorkItemRowSetsWrapper> GetIEnumerableInstance() { return new List<IWorkItemRowSetsWrapper> {GetInstance()}; }

        internal static IWorkItemRowSetsWrapper GetInstance()
        {
            IWorkItemRowSets real = default(IWorkItemRowSets);
            RealInstanceFactory(ref real);
            var instance = (IWorkItemRowSetsWrapper) IWorkItemRowSetsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IWorkItemRowSetsWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref IWorkItemRowSets real, [CallerMemberName] string callerName = "");
    }
}