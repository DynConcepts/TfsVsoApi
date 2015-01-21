using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IssuedTokenProviderImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BeginGetToken_UnitTest()
        {
            TimeSpan timeout = default(TimeSpan);
            AsyncCallback callback = default(AsyncCallback);
            Object state = default(Object);
            ExecuteMethod(
                () => { return (IIssuedTokenProvider) GetInstance(); },
                instance =>
                {
                    timeout = default(TimeSpan); //No Constructor
                    callback = default(AsyncCallback); //No Constructor
                    state = new Object();
                    BeginGetToken_PreCondition(instance, ref timeout, ref callback, ref state);
                },
                instance => { instance.BeginGetToken(timeout, callback, state); },
                instance => { BeginGetToken_PostValidate(instance, timeout, callback, state); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CurrentToken_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIssuedTokenProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CurrentToken; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EndGetToken_UnitTest()
        {
            IAsyncResult result = default(IAsyncResult);
            ExecuteMethod(
                () => { return (IIssuedTokenProvider) GetInstance(); },
                instance =>
                {
                    result = default(IAsyncResult); //No Constructor
                    EndGetToken_PreCondition(instance, ref result);
                },
                instance => { instance.EndGetToken(result); },
                instance => { EndGetToken_PostValidate(instance, result); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTokenIsInteractive_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIssuedTokenProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.GetTokenIsInteractive; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetToken_UnitTest()
        {
            TimeSpan timeout = default(TimeSpan);
            ExecuteMethod(
                () => { return (IIssuedTokenProvider) GetInstance(); },
                instance =>
                {
                    timeout = default(TimeSpan); //No Constructor
                    GetToken_PreCondition(instance, ref timeout);
                },
                instance => { instance.GetToken(timeout); },
                instance => { GetToken_PostValidate(instance, timeout); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SignInUrl_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIssuedTokenProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SignInUrl; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void BeginGetToken_PostValidate(IIssuedTokenProvider instance, TimeSpan timeout, AsyncCallback callback, Object state);
        partial void BeginGetToken_PreCondition(IIssuedTokenProvider instance, ref TimeSpan timeout, ref AsyncCallback callback, ref Object state);

        partial void CurrentToken_SetCondition(ref IIssuedTokenProvider instance, ref IIssuedToken setValue);
        partial void EndGetToken_PostValidate(IIssuedTokenProvider instance, IAsyncResult result);
        partial void EndGetToken_PreCondition(IIssuedTokenProvider instance, ref IAsyncResult result);
        internal static IEnumerable<IssuedTokenProviderImpl> GetIEnumerableInstance() { return new List<IssuedTokenProviderImpl> {GetInstance()}; }

        internal static IssuedTokenProviderImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IssuedTokenProviderImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetTokenIsInteractive_SetCondition(ref IIssuedTokenProvider instance, ref Boolean setValue);
        partial void GetToken_PostValidate(IIssuedTokenProvider instance, TimeSpan timeout);
        partial void GetToken_PreCondition(IIssuedTokenProvider instance, ref TimeSpan timeout);
        static partial void InstanceFactory(ref IssuedTokenProviderImpl instance, [CallerMemberName] string callerName = "");

        partial void SignInUrl_SetCondition(ref IIssuedTokenProvider instance, ref Uri setValue);
    }
}