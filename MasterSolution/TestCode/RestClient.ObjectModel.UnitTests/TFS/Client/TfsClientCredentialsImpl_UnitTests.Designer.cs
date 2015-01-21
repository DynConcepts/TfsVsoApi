using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsClientCredentialsImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AllowInteractive_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsClientCredentials) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    AllowInteractive_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.AllowInteractive = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.AllowInteractive; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Federated_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsClientCredentials) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IFederatedCredential setValue = default(IFederatedCredential);
                    Federated_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Federated = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Federated; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SignOut_UnitTest()
        {
            Uri serverUrl = default(Uri);
            IIServerDataProvider serverDataProvider = default(IIServerDataProvider);
            ExecuteMethod(
                () => { return (ITfsClientCredentials) GetInstance(); },
                instance =>
                {
                    serverUrl = default(Uri); //No Type
                    serverDataProvider = IServerDataProviderImpl_UnitTests.GetInstance();
                    SignOut_PreCondition(instance, ref serverUrl, ref serverDataProvider);
                },
                instance => { instance.SignOut(serverUrl, serverDataProvider); },
                instance => { SignOut_PostValidate(instance, serverUrl, serverDataProvider); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TryGetTokenProvider_UnitTest()
        {
            Uri serverUrl = default(Uri);
            IIssuedTokenProvider provider = default(IIssuedTokenProvider);
            ExecuteMethod(
                () => { return (ITfsClientCredentials) GetInstance(); },
                instance =>
                {
                    serverUrl = default(Uri); //No Type
                    provider = IssuedTokenProviderImpl_UnitTests.GetInstance();
                    TryGetTokenProvider_PreCondition(instance, ref serverUrl, ref provider);
                },
                instance => { instance.TryGetTokenProvider(serverUrl, out provider); },
                instance => { TryGetTokenProvider_PostValidate(instance, serverUrl, provider); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Windows_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsClientCredentials) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IWindowsCredential setValue = default(IWindowsCredential);
                    Windows_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Windows = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Windows; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AllowInteractive_SetCondition(ref ITfsClientCredentials instance, ref Boolean setValue);

        partial void Federated_SetCondition(ref ITfsClientCredentials instance, ref IFederatedCredential setValue);
        internal static IEnumerable<TfsClientCredentialsImpl> GetIEnumerableInstance() { return new List<TfsClientCredentialsImpl> {GetInstance()}; }

        internal static TfsClientCredentialsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TfsClientCredentialsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref TfsClientCredentialsImpl instance, [CallerMemberName] string callerName = "");
        partial void SignOut_PostValidate(ITfsClientCredentials instance, Uri serverUrl, IIServerDataProvider serverDataProvider);
        partial void SignOut_PreCondition(ITfsClientCredentials instance, ref Uri serverUrl, ref IIServerDataProvider serverDataProvider);
        partial void TryGetTokenProvider_PostValidate(ITfsClientCredentials instance, Uri serverUrl, IIssuedTokenProvider provider);
        partial void TryGetTokenProvider_PreCondition(ITfsClientCredentials instance, ref Uri serverUrl, ref IIssuedTokenProvider provider);

        partial void Windows_SetCondition(ref ITfsClientCredentials instance, ref IWindowsCredential setValue);
    }
}