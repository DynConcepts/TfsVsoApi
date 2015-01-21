using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IssuedTokenCredentialWrapper_UnitTests : DynTestClassBase
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

        internal static IEnumerable<IssuedTokenCredentialWrapper> GetIEnumerableInstance() { return new List<IssuedTokenCredentialWrapper> {GetInstance()}; }

        internal static IssuedTokenCredentialWrapper GetInstance()
        {
            IssuedTokenCredential real = default(IssuedTokenCredential);
            RealInstanceFactory(ref real);
            var instance = (IssuedTokenCredentialWrapper) IssuedTokenCredentialWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IssuedTokenCredentialWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref IssuedTokenCredential real, [CallerMemberName] string callerName = "");

        partial void TokenStorage_SetCondition(ref IIssuedTokenCredential instance, ref ITfsClientCredentialStorage setValue);
    }
}