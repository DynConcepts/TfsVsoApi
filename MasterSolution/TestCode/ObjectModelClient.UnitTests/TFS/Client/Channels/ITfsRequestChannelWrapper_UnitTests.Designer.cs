using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ITfsRequestChannelWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Abort_UnitTest()
        {
            ExecuteMethod(
                () => { return (IITfsRequestChannel) GetInstance(); },
                instance => { Abort_PreCondition(instance); },
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
                    message = TfsMessageWrapper_UnitTests.GetInstance();
                    callback = default(AsyncCallback); //No Constructor
                    state = new Object();
                    BeginRequest_PreCondition(instance, ref message, ref callback, ref state);
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
                    EndRequest_PreCondition(instance, ref result);
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
                    message = TfsMessageWrapper_UnitTests.GetInstance();
                    Request_PreCondition(instance, ref message);
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
        partial void Abort_PreCondition(IITfsRequestChannel instance);
        partial void BeginRequest_PostValidate(IITfsRequestChannel instance, ITfsMessage message, AsyncCallback callback, Object state);
        partial void BeginRequest_PreCondition(IITfsRequestChannel instance, ref ITfsMessage message, ref AsyncCallback callback, ref Object state);

        partial void Culture_SetCondition(ref IITfsRequestChannel instance, ref CultureInfo setValue);
        partial void EndRequest_PostValidate(IITfsRequestChannel instance, IAsyncResult result);
        partial void EndRequest_PreCondition(IITfsRequestChannel instance, ref IAsyncResult result);
        internal static IEnumerable<ITfsRequestChannelWrapper> GetIEnumerableInstance() { return new List<ITfsRequestChannelWrapper> {GetInstance()}; }

        internal static ITfsRequestChannelWrapper GetInstance()
        {
            ITfsRequestChannel real = default(ITfsRequestChannel);
            RealInstanceFactory(ref real);
            var instance = (ITfsRequestChannelWrapper) ITfsRequestChannelWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ITfsRequestChannelWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref ITfsRequestChannel real, [CallerMemberName] string callerName = "");
        partial void Request_PostValidate(IITfsRequestChannel instance, ITfsMessage message);
        partial void Request_PreCondition(IITfsRequestChannel instance, ref ITfsMessage message);

        partial void SessionId_SetCondition(ref IITfsRequestChannel instance, ref Guid setValue);

        partial void Settings_SetCondition(ref IITfsRequestChannel instance, ref ITfsRequestSettings setValue);

        partial void State_SetCondition(ref IITfsRequestChannel instance, ref ITfsHttpClientState setValue);
        partial void Uri_SetCondition(ref IITfsRequestChannel instance, ref Uri setValue);
    }
}