using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IssuedTokenCredentialImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TokenStorage_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIssuedTokenCredential) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    ITfsClientCredentialStorage setValue = default(ITfsClientCredentialStorage);
                    TokenStorage_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.TokenStorage = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.TokenStorage; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<IssuedTokenCredentialImpl> GetIEnumerableInstance() { return new List<IssuedTokenCredentialImpl> {GetInstance()}; }

        internal static IssuedTokenCredentialImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IssuedTokenCredentialImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IssuedTokenCredentialImpl instance, [CallerMemberName] string callerName = "");

        partial void TokenStorage_SetCondition(ref IIssuedTokenCredential instance, ref ITfsClientCredentialStorage setValue);
    }
}