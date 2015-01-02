using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ITfsRequestChannelImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Abort_UnitTest()
        {
            ExecuteMethod(
                () => { return (IITfsRequestChannel) GetInstance(); },
                instance => { Abort_PreCondition(ref instance); },
                instance => { instance.Abort(); },
                instance => { Abort_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BeginRequest_UnitTest()
        {
            ITfsMessage message = default(ITfsMessage);
            AsyncCallback callback = default(AsyncCallback);
            Object state = default(Object);
            ExecuteMethod(
                () => { return (IITfsRequestChannel) GetInstance(); },
                instance =>
                {
                    message = TfsMessageImpl_UnitTests.GetInstance();
                    callback = default(AsyncCallback); //No Constructor
                    state = new Object();
                    BeginRequest_PreCondition(ref instance, ref message, ref callback, ref state);
                },
                instance => { instance.BeginRequest(message, callback, state); },
                instance => { BeginRequest_PostValidate(instance, message, callback, state); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Culture_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IITfsRequestChannel) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Culture; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EndRequest_UnitTest()
        {
            IAsyncResult result = default(IAsyncResult);
            ExecuteMethod(
                () => { return (IITfsRequestChannel) GetInstance(); },
                instance =>
                {
                    result = default(IAsyncResult); //No Constructor
                    EndRequest_PreCondition(ref instance, ref result);
                },
                instance => { instance.EndRequest(result); },
                instance => { EndRequest_PostValidate(instance, result); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Request_UnitTest()
        {
            ITfsMessage message = default(ITfsMessage);
            ExecuteMethod(
                () => { return (IITfsRequestChannel) GetInstance(); },
                instance =>
                {
                    message = TfsMessageImpl_UnitTests.GetInstance();
                    Request_PreCondition(ref instance, ref message);
                },
                instance => { instance.Request(message); },
                instance => { Request_PostValidate(instance, message); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SessionId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IITfsRequestChannel) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SessionId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Settings_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IITfsRequestChannel) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Settings; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void State_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IITfsRequestChannel) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.State; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Uri_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IITfsRequestChannel) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Uri; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Abort_PostValidate(IITfsRequestChannel instance);
        partial void Abort_PreCondition(ref IITfsRequestChannel instance);
        partial void BeginRequest_PostValidate(IITfsRequestChannel instance, ITfsMessage message, AsyncCallback callback, Object state);
        partial void BeginRequest_PreCondition(ref IITfsRequestChannel instance, ref ITfsMessage message, ref AsyncCallback callback, ref Object state);

        partial void Culture_SetCondition(ref IITfsRequestChannel instance, ref CultureInfo setValue);
        partial void EndRequest_PostValidate(IITfsRequestChannel instance, IAsyncResult result);
        partial void EndRequest_PreCondition(ref IITfsRequestChannel instance, ref IAsyncResult result);
        internal static IEnumerable<ITfsRequestChannelImpl> GetIEnumerableInstance() { return new List<ITfsRequestChannelImpl> {GetInstance()}; }

        internal static ITfsRequestChannelImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ITfsRequestChannelImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ITfsRequestChannelImpl instance, [CallerMemberName] string callerName = "");
        partial void Request_PostValidate(IITfsRequestChannel instance, ITfsMessage message);
        partial void Request_PreCondition(ref IITfsRequestChannel instance, ref ITfsMessage message);

        partial void SessionId_SetCondition(ref IITfsRequestChannel instance, ref Guid setValue);

        partial void Settings_SetCondition(ref IITfsRequestChannel instance, ref ITfsRequestSettings setValue);

        partial void State_SetCondition(ref IITfsRequestChannel instance, ref ITfsHttpClientState setValue);
        partial void Uri_SetCondition(ref IITfsRequestChannel instance, ref Uri setValue);
    }
}