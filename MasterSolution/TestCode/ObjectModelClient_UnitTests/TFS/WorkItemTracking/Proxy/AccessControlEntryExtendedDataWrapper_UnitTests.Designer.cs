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
    public partial class AccessControlEntryExtendedDataWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<AccessControlEntryExtendedDataWrapper> GetIEnumerableInstance() { return new List<AccessControlEntryExtendedDataWrapper> {GetInstance()}; }

        internal static AccessControlEntryExtendedDataWrapper GetInstance()
        {
            AccessControlEntryExtendedData real = default(AccessControlEntryExtendedData);
            RealInstanceFactory(ref real);
            var instance = (AccessControlEntryExtendedDataWrapper) AccessControlEntryExtendedDataWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref AccessControlEntryExtendedDataWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref AccessControlEntryExtendedData real, [CallerMemberName] string callerName = "");
    }
}