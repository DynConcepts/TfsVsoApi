using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects.Communications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.Communications
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class HttpClientLive_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BaseAddress_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    HttpClientLive instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    Uri setValue = default(Uri);
                    BaseAddress_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.BaseAddress = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.BaseAddress; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CancelPendingRequests_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { CancelPendingRequests_PreCondition(ref instance); },
                instance => { instance.CancelPendingRequests(); },
                instance => { CancelPendingRequests_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DefaultRequestHeaders_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    HttpClientLive instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DefaultRequestHeaders; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DeleteAsync_UnitTest()
        {
            String requestUri = default(String);
            Task<HttpResponseMessage> _retVal = default(Task<HttpResponseMessage>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    requestUri = default(String); //No Constructor
                    DeleteAsync_PreCondition(ref instance, ref requestUri);
                },
                instance => { _retVal = instance.DeleteAsync(requestUri); },
                instance => { DeleteAsync_PostValidate(instance, requestUri, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Dispose_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { Dispose_PreCondition(ref instance); },
                instance => { instance.Dispose(); },
                instance => { Dispose_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Equals_UnitTest()
        {
            Object obj = default(Object);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAsync_UnitTest()
        {
            Uri requestUri = default(Uri);
            CancellationToken cancellationToken = default(CancellationToken);
            Task<HttpResponseMessage> _retVal = default(Task<HttpResponseMessage>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    requestUri = default(Uri); //No Constructor
                    cancellationToken = default(CancellationToken); //No Constructor
                    GetAsync_PreCondition(ref instance, ref requestUri, ref cancellationToken);
                },
                instance => { _retVal = instance.GetAsync(requestUri, cancellationToken); },
                instance => { GetAsync_PostValidate(instance, requestUri, cancellationToken, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetByteArrayAsync_UnitTest()
        {
            String requestUri = default(String);
            Task<Byte[]> _retVal = default(Task<Byte[]>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    requestUri = default(String); //No Constructor
                    GetByteArrayAsync_PreCondition(ref instance, ref requestUri);
                },
                instance => { _retVal = instance.GetByteArrayAsync(requestUri); },
                instance => { GetByteArrayAsync_PostValidate(instance, requestUri, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetStreamAsync_UnitTest()
        {
            String requestUri = default(String);
            Task<Stream> _retVal = default(Task<Stream>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    requestUri = default(String); //No Constructor
                    GetStreamAsync_PreCondition(ref instance, ref requestUri);
                },
                instance => { _retVal = instance.GetStreamAsync(requestUri); },
                instance => { GetStreamAsync_PostValidate(instance, requestUri, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetStringAsync_UnitTest()
        {
            String requestUri = default(String);
            Task<String> _retVal = default(Task<String>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    requestUri = default(String); //No Constructor
                    GetStringAsync_PreCondition(ref instance, ref requestUri);
                },
                instance => { _retVal = instance.GetStringAsync(requestUri); },
                instance => { GetStringAsync_PostValidate(instance, requestUri, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void MaxResponseContentBufferSize_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    HttpClientLive instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    long setValue = default(Int64);
                    MaxResponseContentBufferSize_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.MaxResponseContentBufferSize = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.MaxResponseContentBufferSize; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PostAsync_UnitTest()
        {
            String requestUri = default(String);
            HttpContent content = default(HttpContent);
            Task<HttpResponseMessage> _retVal = default(Task<HttpResponseMessage>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    requestUri = default(String); //No Constructor
                    content = default(HttpContent); //No Constructor
                    PostAsync_PreCondition(ref instance, ref requestUri, ref content);
                },
                instance => { _retVal = instance.PostAsync(requestUri, content); },
                instance => { PostAsync_PostValidate(instance, requestUri, content, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PutAsync_UnitTest()
        {
            String requestUri = default(String);
            HttpContent content = default(HttpContent);
            Task<HttpResponseMessage> _retVal = default(Task<HttpResponseMessage>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    requestUri = default(String); //No Constructor
                    content = default(HttpContent); //No Constructor
                    PutAsync_PreCondition(ref instance, ref requestUri, ref content);
                },
                instance => { _retVal = instance.PutAsync(requestUri, content); },
                instance => { PutAsync_PostValidate(instance, requestUri, content, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SendAsync_UnitTest()
        {
            HttpRequestMessage request = default(HttpRequestMessage);
            Task<HttpResponseMessage> _retVal = default(Task<HttpResponseMessage>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    request = new HttpRequestMessage();
                    SendAsync_PreCondition(ref instance, ref request);
                },
                instance => { _retVal = instance.SendAsync(request); },
                instance => { SendAsync_PostValidate(instance, request, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Timeout_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    HttpClientLive instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    TimeSpan setValue = default(TimeSpan);
                    Timeout_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Timeout = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Timeout; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void BaseAddress_SetCondition(ref HttpClientLive instance, ref Uri setValue);

        partial void CancelPendingRequests_PostValidate(HttpClientLive instance);
        partial void CancelPendingRequests_PreCondition(ref HttpClientLive instance);
        partial void DefaultRequestHeaders_SetCondition(ref HttpClientLive instance, ref HttpRequestHeaders setValue);
        partial void DeleteAsync_PostValidate(HttpClientLive instance, String requestUri, Task<HttpResponseMessage> _retVal);
        partial void DeleteAsync_PreCondition(ref HttpClientLive instance, ref String requestUri);

        partial void Dispose_PostValidate(HttpClientLive instance);
        partial void Dispose_PreCondition(ref HttpClientLive instance);

        partial void Equals_PostValidate(HttpClientLive instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref HttpClientLive instance, ref Object obj);
        partial void GetAsync_PostValidate(HttpClientLive instance, Uri requestUri, CancellationToken cancellationToken, Task<HttpResponseMessage> _retVal);
        partial void GetAsync_PreCondition(ref HttpClientLive instance, ref Uri requestUri, ref CancellationToken cancellationToken);
        partial void GetByteArrayAsync_PostValidate(HttpClientLive instance, String requestUri, Task<Byte[]> _retVal);
        partial void GetByteArrayAsync_PreCondition(ref HttpClientLive instance, ref String requestUri);

        partial void GetHashCode_PostValidate(HttpClientLive instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref HttpClientLive instance);

        internal static IEnumerable<HttpClientLive> GetIEnumerableInstance()
        {
            return new List<HttpClientLive> {GetInstance()};
        }

        internal static HttpClientLive GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new HttpClientLive();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetStreamAsync_PostValidate(HttpClientLive instance, String requestUri, Task<Stream> _retVal);
        partial void GetStreamAsync_PreCondition(ref HttpClientLive instance, ref String requestUri);
        partial void GetStringAsync_PostValidate(HttpClientLive instance, String requestUri, Task<String> _retVal);
        partial void GetStringAsync_PreCondition(ref HttpClientLive instance, ref String requestUri);

        partial void GetType_PostValidate(HttpClientLive instance, Type _retVal);
        partial void GetType_PreCondition(ref HttpClientLive instance);
        static partial void InstanceFactory(ref HttpClientLive instance, [CallerMemberName] string callerName = "");

        partial void MaxResponseContentBufferSize_SetCondition(ref HttpClientLive instance, ref Int64 setValue);
        partial void PostAsync_PostValidate(HttpClientLive instance, String requestUri, HttpContent content, Task<HttpResponseMessage> _retVal);
        partial void PostAsync_PreCondition(ref HttpClientLive instance, ref String requestUri, ref HttpContent content);
        partial void PutAsync_PostValidate(HttpClientLive instance, String requestUri, HttpContent content, Task<HttpResponseMessage> _retVal);
        partial void PutAsync_PreCondition(ref HttpClientLive instance, ref String requestUri, ref HttpContent content);
        partial void SendAsync_PostValidate(HttpClientLive instance, HttpRequestMessage request, Task<HttpResponseMessage> _retVal);
        partial void SendAsync_PreCondition(ref HttpClientLive instance, ref HttpRequestMessage request);
        partial void Timeout_SetCondition(ref HttpClientLive instance, ref TimeSpan setValue);
        partial void ToString_PostValidate(HttpClientLive instance, String _retVal);
        partial void ToString_PreCondition(ref HttpClientLive instance);
    }
}