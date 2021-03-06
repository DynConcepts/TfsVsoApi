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
    public partial class IMetadataRowSetsWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IMetadataRowSetsWrapper> GetIEnumerableInstance() { return new List<IMetadataRowSetsWrapper> {GetInstance()}; }

        internal static IMetadataRowSetsWrapper GetInstance()
        {
            IMetadataRowSets real = default(IMetadataRowSets);
            RealInstanceFactory(ref real);
            var instance = (IMetadataRowSetsWrapper) IMetadataRowSetsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IMetadataRowSetsWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref IMetadataRowSets real, [CallerMemberName] string callerName = "");
    }
}