using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class FederatedCredentialImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<FederatedCredentialImpl> GetIEnumerableInstance() { return new List<FederatedCredentialImpl> {GetInstance()}; }

        internal static FederatedCredentialImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new FederatedCredentialImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref FederatedCredentialImpl instance, [CallerMemberName] string callerName = "");
    }
}