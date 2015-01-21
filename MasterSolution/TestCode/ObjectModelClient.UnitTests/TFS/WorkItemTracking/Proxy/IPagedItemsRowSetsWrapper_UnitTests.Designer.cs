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
    public partial class IPagedItemsRowSetsWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IPagedItemsRowSetsWrapper> GetIEnumerableInstance() { return new List<IPagedItemsRowSetsWrapper> {GetInstance()}; }

        internal static IPagedItemsRowSetsWrapper GetInstance()
        {
            IPagedItemsRowSets real = default(IPagedItemsRowSets);
            RealInstanceFactory(ref real);
            var instance = (IPagedItemsRowSetsWrapper) IPagedItemsRowSetsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IPagedItemsRowSetsWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref IPagedItemsRowSets real, [CallerMemberName] string callerName = "");
    }
}