using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AccessControlEntryDataImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<AccessControlEntryDataImpl> GetIEnumerableInstance() { return new List<AccessControlEntryDataImpl> {GetInstance()}; }

        internal static AccessControlEntryDataImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new AccessControlEntryDataImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref AccessControlEntryDataImpl instance, [CallerMemberName] string callerName = "");
    }
}