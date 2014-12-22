using System;
using System.Collections.Generic;
using System.Net;
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
    public partial class ITfsRequestListenerWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AfterReceiveReply_UnitTest()
        {
            Int64 requestId = default(Int64);
            String methodName = default(String);
            HttpWebResponse response = default(HttpWebResponse);
            ExecuteMethod(
                () => { return (IITfsRequestListener) GetInstance(); },
                instance =>
                {
                    requestId = default(Int64); //No Constructor
                    methodName = default(String); //No Constructor
                    response = default(HttpWebResponse); //No Type
                    AfterReceiveReply_PreCondition(ref instance, ref requestId, ref methodName, ref response);
                },
                instance => { instance.AfterReceiveReply(requestId, methodName, response); },
                instance => { AfterReceiveReply_PostValidate(instance, requestId, methodName, response); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BeforeSendRequest_UnitTest()
        {
            Int64 requestId = default(Int64);
            String methodName = default(String);
            HttpWebRequest request = default(HttpWebRequest);
            ExecuteMethod(
                () => { return (IITfsRequestListener) GetInstance(); },
                instance =>
                {
                    requestId = default(Int64); //No Constructor
                    methodName = default(String); //No Constructor
                    request = default(HttpWebRequest); //No Type
                    BeforeSendRequest_PreCondition(ref instance, ref requestId, ref methodName, ref request);
                },
                instance => { instance.BeforeSendRequest(requestId, methodName, request); },
                instance => { BeforeSendRequest_PostValidate(instance, requestId, methodName, request); });
        }

        partial void AfterReceiveReply_PostValidate(IITfsRequestListener instance, Int64 requestId, String methodName, HttpWebResponse response);
        partial void AfterReceiveReply_PreCondition(ref IITfsRequestListener instance, ref Int64 requestId, ref String methodName, ref HttpWebResponse response);
        partial void BeforeSendRequest_PostValidate(IITfsRequestListener instance, Int64 requestId, String methodName, HttpWebRequest request);
        partial void BeforeSendRequest_PreCondition(ref IITfsRequestListener instance, ref Int64 requestId, ref String methodName, ref HttpWebRequest request);
        internal static IEnumerable<ITfsRequestListenerWrapper> GetIEnumerableInstance() { return new List<ITfsRequestListenerWrapper> {GetInstance()}; }

        internal static ITfsRequestListenerWrapper GetInstance()
        {
            ITfsRequestListener real = default(ITfsRequestListener);
            RealInstanceFactory(ref real);
            var instance = (ITfsRequestListenerWrapper) ITfsRequestListenerWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ITfsRequestListenerWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref ITfsRequestListener real, [CallerMemberName] string callerName = "");
    }
}