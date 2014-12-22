using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IMetadataRowSetsImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IMetadataRowSetsImpl> GetIEnumerableInstance() { return new List<IMetadataRowSetsImpl> {GetInstance()}; }

        internal static IMetadataRowSetsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IMetadataRowSetsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IMetadataRowSetsImpl instance, [CallerMemberName] string callerName = "");
    }
}