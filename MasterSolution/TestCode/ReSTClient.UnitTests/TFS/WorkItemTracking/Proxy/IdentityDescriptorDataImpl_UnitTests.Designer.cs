using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IdentityDescriptorDataImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IdentityDescriptorDataImpl> GetIEnumerableInstance() { return new List<IdentityDescriptorDataImpl> {GetInstance()}; }

        internal static IdentityDescriptorDataImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IdentityDescriptorDataImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IdentityDescriptorDataImpl instance, [CallerMemberName] string callerName = "");
    }
}