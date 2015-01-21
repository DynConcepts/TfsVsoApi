using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects.Communications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.Communications
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class StructuredHttpExchange_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BaseRoute_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    BaseRoute_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.BaseRoute = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.BaseRoute; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Body_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Body_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Body = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Body; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
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
        public void Exception_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Exception; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FormattedRequest_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FormattedRequest; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
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
        public void Get_UnitTest()
        {
            CallSpec spec = default(CallSpec);
            StructuredHttpExchange _retVal = default(StructuredHttpExchange);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    spec = default(CallSpec); //No Constructor
                    Get_PreCondition(ref instance, ref spec);
                },
                instance => { _retVal = StructuredHttpExchange.Get(spec); },
                instance => { Get_PostValidate(instance, spec, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Host_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Host_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Host = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Host; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void MarkAsComplete_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { MarkAsComplete_PreCondition(ref instance); },
                instance => { instance.MarkAsComplete(); },
                instance => { MarkAsComplete_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Method_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    HttpMethod setValue = default(HttpMethod);
                    Method_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Method = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Method; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void NetworkTime_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    TimeSpan setValue = default(TimeSpan);
                    NetworkTime_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.NetworkTime = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.NetworkTime; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Options_UnitTest()
        {
            String relativeRoute = default(String);
            StructuredHttpExchange _retVal = default(StructuredHttpExchange);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    relativeRoute = default(String); //No Constructor
                    Options_PreCondition(ref instance, ref relativeRoute);
                },
                instance => { _retVal = StructuredHttpExchange.Options(relativeRoute); },
                instance => { Options_PostValidate(instance, relativeRoute, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Patch_UnitTest()
        {
            String relativeRoute = default(String);
            String body = default(String);
            StructuredHttpExchange _retVal = default(StructuredHttpExchange);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    relativeRoute = default(String); //No Constructor
                    body = default(String); //No Constructor
                    Patch_PreCondition(ref instance, ref relativeRoute, ref body);
                },
                instance => { _retVal = StructuredHttpExchange.Patch(relativeRoute, body); },
                instance => { Patch_PostValidate(instance, relativeRoute, body, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Post_UnitTest()
        {
            String relativeRoute = default(String);
            String body = default(String);
            StructuredHttpExchange _retVal = default(StructuredHttpExchange);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    relativeRoute = default(String); //No Constructor
                    body = default(String); //No Constructor
                    Post_PreCondition(ref instance, ref relativeRoute, ref body);
                },
                instance => { _retVal = StructuredHttpExchange.Post(relativeRoute, body); },
                instance => { Post_PostValidate(instance, relativeRoute, body, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ProcessingTime_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ProcessingTime; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryStringParameters_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.QueryStringParameters; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RecordException_UnitTest()
        {
            Exception exception = default(Exception);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    exception = new Exception();
                    RecordException_PreCondition(ref instance, ref exception);
                },
                instance => { instance.RecordException(exception); },
                instance => { RecordException_PostValidate(instance, exception); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RelativeRoute_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    RelativeRoute_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.RelativeRoute = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.RelativeRoute; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RequestMessage_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RequestMessage; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RequestPositionalParameters_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RequestPositionalParameters; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Response_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Response_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Response = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Response; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetParameter_UnitTest()
        {
            Int32 position = default(Int32);
            Object value = default(Object);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    position = default(Int32); //No Constructor
                    value = new Object();
                    SetParameter_PreCondition(ref instance, ref position, ref value);
                },
                instance => { instance.SetParameter(position, value); },
                instance => { SetParameter_PostValidate(instance, position, value); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetQuery_UnitTest()
        {
            String key = default(String);
            Object value = default(Object);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    key = default(String); //No Constructor
                    value = new Object();
                    SetQuery_PreCondition(ref instance, ref key, ref value);
                },
                instance => { instance.SetQuery(key, value); },
                instance => { SetQuery_PostValidate(instance, key, value); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetRoute_UnitTest()
        {
            String key = default(String);
            Object value = default(Object);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    key = default(String); //No Constructor
                    value = new Object();
                    SetRoute_PreCondition(ref instance, ref key, ref value);
                },
                instance => { instance.SetRoute(key, value); },
                instance => { SetRoute_PostValidate(instance, key, value); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TimeStamp_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.TimeStamp; },
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

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TotalTime_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    StructuredHttpExchange instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    TimeSpan setValue = default(TimeSpan);
                    TotalTime_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.TotalTime = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.TotalTime; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void BaseRoute_SetCondition(ref StructuredHttpExchange instance, ref String setValue);

        partial void Body_SetCondition(ref StructuredHttpExchange instance, ref String setValue);
        partial void Equals_PostValidate(StructuredHttpExchange instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref StructuredHttpExchange instance, ref Object obj);

        partial void Exception_SetCondition(ref StructuredHttpExchange instance, ref Exception setValue);

        partial void FormattedRequest_SetCondition(ref StructuredHttpExchange instance, ref String setValue);
        partial void GetHashCode_PostValidate(StructuredHttpExchange instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref StructuredHttpExchange instance);

        internal static IEnumerable<StructuredHttpExchange> GetIEnumerableInstance()
        {
            return new List<StructuredHttpExchange> {GetInstance()};
        }

        internal static StructuredHttpExchange GetInstance([CallerMemberName] string callerName = "")
        {
            StructuredHttpExchange instance = default(StructuredHttpExchange);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(StructuredHttpExchange instance, Type _retVal);
        partial void GetType_PreCondition(ref StructuredHttpExchange instance);
        partial void Get_PostValidate(StructuredHttpExchange instance, CallSpec spec, StructuredHttpExchange _retVal);
        partial void Get_PreCondition(ref StructuredHttpExchange instance, ref CallSpec spec);

        partial void Host_SetCondition(ref StructuredHttpExchange instance, ref String setValue);
        static partial void InstanceFactory(ref StructuredHttpExchange instance, [CallerMemberName] string callerName = "");
        partial void MarkAsComplete_PostValidate(StructuredHttpExchange instance);
        partial void MarkAsComplete_PreCondition(ref StructuredHttpExchange instance);

        partial void Method_SetCondition(ref StructuredHttpExchange instance, ref HttpMethod setValue);

        partial void NetworkTime_SetCondition(ref StructuredHttpExchange instance, ref TimeSpan setValue);
        partial void Options_PostValidate(StructuredHttpExchange instance, String relativeRoute, StructuredHttpExchange _retVal);
        partial void Options_PreCondition(ref StructuredHttpExchange instance, ref String relativeRoute);
        partial void Patch_PostValidate(StructuredHttpExchange instance, String relativeRoute, String body, StructuredHttpExchange _retVal);
        partial void Patch_PreCondition(ref StructuredHttpExchange instance, ref String relativeRoute, ref String body);
        partial void Post_PostValidate(StructuredHttpExchange instance, String relativeRoute, String body, StructuredHttpExchange _retVal);
        partial void Post_PreCondition(ref StructuredHttpExchange instance, ref String relativeRoute, ref String body);

        partial void ProcessingTime_SetCondition(ref StructuredHttpExchange instance, ref Object setValue);

        partial void QueryStringParameters_SetCondition(ref StructuredHttpExchange instance, ref Dictionary<String, Object> setValue);
        partial void RecordException_PostValidate(StructuredHttpExchange instance, Exception exception);
        partial void RecordException_PreCondition(ref StructuredHttpExchange instance, ref Exception exception);

        partial void RelativeRoute_SetCondition(ref StructuredHttpExchange instance, ref String setValue);

        partial void RequestMessage_SetCondition(ref StructuredHttpExchange instance, ref HttpRequestMessage setValue);

        partial void RequestPositionalParameters_SetCondition(ref StructuredHttpExchange instance, ref Dictionary<Int32, Object> setValue);

        partial void Response_SetCondition(ref StructuredHttpExchange instance, ref String setValue);
        partial void SetParameter_PostValidate(StructuredHttpExchange instance, Int32 position, Object value);
        partial void SetParameter_PreCondition(ref StructuredHttpExchange instance, ref Int32 position, ref Object value);
        partial void SetQuery_PostValidate(StructuredHttpExchange instance, String key, Object value);
        partial void SetQuery_PreCondition(ref StructuredHttpExchange instance, ref String key, ref Object value);
        partial void SetRoute_PostValidate(StructuredHttpExchange instance, String key, Object value);
        partial void SetRoute_PreCondition(ref StructuredHttpExchange instance, ref String key, ref Object value);

        partial void TimeStamp_SetCondition(ref StructuredHttpExchange instance, ref DateTime setValue);
        partial void ToString_PostValidate(StructuredHttpExchange instance, String _retVal);
        partial void ToString_PreCondition(ref StructuredHttpExchange instance);

        partial void TotalTime_SetCondition(ref StructuredHttpExchange instance, ref TimeSpan setValue);
    }
}