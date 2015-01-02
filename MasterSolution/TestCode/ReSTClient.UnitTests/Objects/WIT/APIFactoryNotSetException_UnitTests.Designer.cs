using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class APIFactoryNotSetException_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Data_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    APIFactoryNotSetException instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Data; },
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
        public void GetBaseException_UnitTest()
        {
            Exception _retVal = default(Exception);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetBaseException_PreCondition(ref instance); },
                instance => { _retVal = instance.GetBaseException(); },
                instance => { GetBaseException_PostValidate(instance, _retVal); });
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
        public void GetObjectData_UnitTest()
        {
            SerializationInfo info = default(SerializationInfo);
            StreamingContext context = default(StreamingContext);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    info = default(SerializationInfo); //No Constructor
                    context = default(StreamingContext); //No Constructor
                    GetObjectData_PreCondition(ref instance, ref info, ref context);
                },
                instance => { instance.GetObjectData(info, context); },
                instance => { GetObjectData_PostValidate(instance, info, context); });
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
        public void HResult_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    APIFactoryNotSetException instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HResult; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HelpLink_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    APIFactoryNotSetException instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    HelpLink_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.HelpLink = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.HelpLink; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void InnerException_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    APIFactoryNotSetException instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.InnerException; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Message_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    APIFactoryNotSetException instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Message; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Source_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    APIFactoryNotSetException instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Source_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Source = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Source; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void StackTrace_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    APIFactoryNotSetException instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.StackTrace; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TargetSite_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    APIFactoryNotSetException instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.TargetSite; },
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

        partial void Data_SetCondition(ref APIFactoryNotSetException instance, ref IDictionary setValue);
        partial void Equals_PostValidate(APIFactoryNotSetException instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref APIFactoryNotSetException instance, ref Object obj);
        partial void GetBaseException_PostValidate(APIFactoryNotSetException instance, Exception _retVal);
        partial void GetBaseException_PreCondition(ref APIFactoryNotSetException instance);
        partial void GetHashCode_PostValidate(APIFactoryNotSetException instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref APIFactoryNotSetException instance);
        internal static IEnumerable<APIFactoryNotSetException> GetIEnumerableInstance() { return new List<APIFactoryNotSetException> {GetInstance()}; }

        internal static APIFactoryNotSetException GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new APIFactoryNotSetException();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetObjectData_PostValidate(APIFactoryNotSetException instance, SerializationInfo info, StreamingContext context);
        partial void GetObjectData_PreCondition(ref APIFactoryNotSetException instance, ref SerializationInfo info, ref StreamingContext context);
        partial void GetType_PostValidate(APIFactoryNotSetException instance, Type _retVal);
        partial void GetType_PreCondition(ref APIFactoryNotSetException instance);
        partial void HResult_SetCondition(ref APIFactoryNotSetException instance, ref Int32 setValue);

        partial void HelpLink_SetCondition(ref APIFactoryNotSetException instance, ref String setValue);
        partial void InnerException_SetCondition(ref APIFactoryNotSetException instance, ref Exception setValue);
        static partial void InstanceFactory(ref APIFactoryNotSetException instance, [CallerMemberName] string callerName = "");
        partial void Message_SetCondition(ref APIFactoryNotSetException instance, ref String setValue);

        partial void Source_SetCondition(ref APIFactoryNotSetException instance, ref String setValue);
        partial void StackTrace_SetCondition(ref APIFactoryNotSetException instance, ref String setValue);
        partial void TargetSite_SetCondition(ref APIFactoryNotSetException instance, ref MethodBase setValue);
        partial void ToString_PostValidate(APIFactoryNotSetException instance, String _retVal);
        partial void ToString_PreCondition(ref APIFactoryNotSetException instance);
    }
}