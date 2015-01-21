using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class FederatedCredentialWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<FederatedCredentialWrapper> GetIEnumerableInstance() { return new List<FederatedCredentialWrapper> {GetInstance()}; }

        internal static FederatedCredentialWrapper GetInstance()
        {
            FederatedCredential real = default(FederatedCredential);
            RealInstanceFactory(ref real);
            var instance = (FederatedCredentialWrapper) FederatedCredentialWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref FederatedCredentialWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref FederatedCredential real, [CallerMemberName] string callerName = "");
    }
}