using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsClientCredentialStorageImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTokenProperty_UnitTest()
        {
            Uri[] serverUrls = default(Uri[]);
            String propertyName = default(String);
            ExecuteMethod(
                () => { return (ITfsClientCredentialStorage) GetInstance(); },
                instance =>
                {
                    serverUrls = default(Uri[]); //No Type
                    propertyName = default(String); //No Constructor
                    GetTokenProperty_PreCondition(ref instance, ref serverUrls, ref propertyName);
                },
                instance => { instance.GetTokenProperty(serverUrls, propertyName); },
                instance => { GetTokenProperty_PostValidate(instance, serverUrls, propertyName); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveTokenValue_UnitTest()
        {
            Uri serverUrl = default(Uri);
            IIssuedToken token = default(IIssuedToken);
            ExecuteMethod(
                () => { return (ITfsClientCredentialStorage) GetInstance(); },
                instance =>
                {
                    serverUrl = default(Uri); //No Type
                    token = IssuedTokenImpl_UnitTests.GetInstance();
                    RemoveTokenValue_PreCondition(ref instance, ref serverUrl, ref token);
                },
                instance => { instance.RemoveTokenValue(serverUrl, token); },
                instance => { RemoveTokenValue_PostValidate(instance, serverUrl, token); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveTokenValuesByUser_UnitTest()
        {
            Guid userId = default(Guid);
            ExecuteMethod(
                () => { return (ITfsClientCredentialStorage) GetInstance(); },
                instance =>
                {
                    userId = default(Guid); //No Constructor
                    RemoveTokenValuesByUser_PreCondition(ref instance, ref userId);
                },
                instance => { instance.RemoveTokenValuesByUser(userId); },
                instance => { RemoveTokenValuesByUser_PostValidate(instance, userId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveToken_UnitTest()
        {
            Uri serverUrl = default(Uri);
            ExecuteMethod(
                () => { return (ITfsClientCredentialStorage) GetInstance(); },
                instance =>
                {
                    serverUrl = default(Uri); //No Type
                    RemoveToken_PreCondition(ref instance, ref serverUrl);
                },
                instance => { instance.RemoveToken(serverUrl); },
                instance => { RemoveToken_PostValidate(instance, serverUrl); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RetrieveToken_UnitTest()
        {
            Uri serverUrl = default(Uri);
            VssCredentialsType credentialType = default(VssCredentialsType);
            ExecuteMethod(
                () => { return (ITfsClientCredentialStorage) GetInstance(); },
                instance =>
                {
                    serverUrl = default(Uri); //No Type
                    credentialType = default(VssCredentialsType); //No Type
                    RetrieveToken_PreCondition(ref instance, ref serverUrl, ref credentialType);
                },
                instance => { instance.RetrieveToken(serverUrl, credentialType); },
                instance => { RetrieveToken_PostValidate(instance, serverUrl, credentialType); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void StoreToken_UnitTest()
        {
            Uri serverUrl = default(Uri);
            IIssuedToken token = default(IIssuedToken);
            Boolean matchUserInformation = default(Boolean);
            ExecuteMethod(
                () => { return (ITfsClientCredentialStorage) GetInstance(); },
                instance =>
                {
                    serverUrl = default(Uri); //No Type
                    token = IssuedTokenImpl_UnitTests.GetInstance();
                    matchUserInformation = default(Boolean); //No Constructor
                    StoreToken_PreCondition(ref instance, ref serverUrl, ref token, ref matchUserInformation);
                },
                instance => { instance.StoreToken(serverUrl, token, matchUserInformation); },
                instance => { StoreToken_PostValidate(instance, serverUrl, token, matchUserInformation); });
        }

        internal static IEnumerable<TfsClientCredentialStorageImpl> GetIEnumerableInstance() { return new List<TfsClientCredentialStorageImpl> {GetInstance()}; }

        internal static TfsClientCredentialStorageImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TfsClientCredentialStorageImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetTokenProperty_PostValidate(ITfsClientCredentialStorage instance, Uri[] serverUrls, String propertyName);
        partial void GetTokenProperty_PreCondition(ref ITfsClientCredentialStorage instance, ref Uri[] serverUrls, ref String propertyName);
        static partial void InstanceFactory(ref TfsClientCredentialStorageImpl instance, [CallerMemberName] string callerName = "");

        partial void RemoveTokenValue_PostValidate(ITfsClientCredentialStorage instance, Uri serverUrl, IIssuedToken token);
        partial void RemoveTokenValue_PreCondition(ref ITfsClientCredentialStorage instance, ref Uri serverUrl, ref IIssuedToken token);

        partial void RemoveTokenValuesByUser_PostValidate(ITfsClientCredentialStorage instance, Guid userId);
        partial void RemoveTokenValuesByUser_PreCondition(ref ITfsClientCredentialStorage instance, ref Guid userId);
        partial void RemoveToken_PostValidate(ITfsClientCredentialStorage instance, Uri serverUrl);
        partial void RemoveToken_PreCondition(ref ITfsClientCredentialStorage instance, ref Uri serverUrl);
        partial void RetrieveToken_PostValidate(ITfsClientCredentialStorage instance, Uri serverUrl, VssCredentialsType credentialType);
        partial void RetrieveToken_PreCondition(ref ITfsClientCredentialStorage instance, ref Uri serverUrl, ref VssCredentialsType credentialType);
        partial void StoreToken_PostValidate(ITfsClientCredentialStorage instance, Uri serverUrl, IIssuedToken token, Boolean matchUserInformation);
        partial void StoreToken_PreCondition(ref ITfsClientCredentialStorage instance, ref Uri serverUrl, ref IIssuedToken token, ref Boolean matchUserInformation);
    }
}