using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IPagedItemsRowSetsImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IPagedItemsRowSetsImpl> GetIEnumerableInstance() { return new List<IPagedItemsRowSetsImpl> {GetInstance()}; }

        internal static IPagedItemsRowSetsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IPagedItemsRowSetsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IPagedItemsRowSetsImpl instance, [CallerMemberName] string callerName = "");
    }
}