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
    public partial class AccessControlEntryDataWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<AccessControlEntryDataWrapper> GetIEnumerableInstance() { return new List<AccessControlEntryDataWrapper> {GetInstance()}; }

        internal static AccessControlEntryDataWrapper GetInstance()
        {
            AccessControlEntryData real = default(AccessControlEntryData);
            RealInstanceFactory(ref real);
            var instance = (AccessControlEntryDataWrapper) AccessControlEntryDataWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref AccessControlEntryDataWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref AccessControlEntryData real, [CallerMemberName] string callerName = "");
    }
}