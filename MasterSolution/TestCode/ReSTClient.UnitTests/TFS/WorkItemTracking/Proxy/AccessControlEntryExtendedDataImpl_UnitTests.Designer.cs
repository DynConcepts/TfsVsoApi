using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AccessControlEntryExtendedDataImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<AccessControlEntryExtendedDataImpl> GetIEnumerableInstance() { return new List<AccessControlEntryExtendedDataImpl> {GetInstance()}; }

        internal static AccessControlEntryExtendedDataImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new AccessControlEntryExtendedDataImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref AccessControlEntryExtendedDataImpl instance, [CallerMemberName] string callerName = "");
    }
}