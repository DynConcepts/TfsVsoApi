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
    public partial class IdentityDescriptorDataWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<IdentityDescriptorDataWrapper> GetIEnumerableInstance() { return new List<IdentityDescriptorDataWrapper> {GetInstance()}; }

        internal static IdentityDescriptorDataWrapper GetInstance()
        {
            IdentityDescriptorData real = default(IdentityDescriptorData);
            RealInstanceFactory(ref real);
            var instance = (IdentityDescriptorDataWrapper) IdentityDescriptorDataWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IdentityDescriptorDataWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref IdentityDescriptorData real, [CallerMemberName] string callerName = "");
    }
}