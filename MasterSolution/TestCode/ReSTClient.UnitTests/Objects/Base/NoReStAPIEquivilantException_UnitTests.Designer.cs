using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.Base
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class NoReStAPIEquivilantException_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Data_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    NoReStAPIEquivilantException instance = GetInstance();
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
                    Equals_PreCondition(instance, ref obj);
                },
                instance => { return _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetBaseException_UnitTest()
        {
            Exception _retVal = default(Exception);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetBaseException_PreCondition(instance); },
                instance => { return _retVal = instance.GetBaseException(); },
                instance => { GetBaseException_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(instance); },
                instance => { return _retVal = instance.GetHashCode(); },
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
                    GetObjectData_PreCondition(instance, ref info, ref context);
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
                instance => { GetType_PreCondition(instance); },
                instance => { return _retVal = instance.GetType(); },
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
                    NoReStAPIEquivilantException instance = GetInstance();
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
                    NoReStAPIEquivilantException instance = GetInstance();
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
                    NoReStAPIEquivilantException instance = GetInstance();
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
                    NoReStAPIEquivilantException instance = GetInstance();
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
                    NoReStAPIEquivilantException instance = GetInstance();
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
                    NoReStAPIEquivilantException instance = GetInstance();
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
                    NoReStAPIEquivilantException instance = GetInstance();
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
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Data_SetCondition(ref NoReStAPIEquivilantException instance, ref IDictionary setValue);
        partial void Equals_PostValidate(NoReStAPIEquivilantException instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(NoReStAPIEquivilantException instance, ref Object obj);
        partial void GetBaseException_PostValidate(NoReStAPIEquivilantException instance, Exception _retVal);
        partial void GetBaseException_PreCondition(NoReStAPIEquivilantException instance);
        partial void GetHashCode_PostValidate(NoReStAPIEquivilantException instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(NoReStAPIEquivilantException instance);
        internal static IEnumerable<NoReStAPIEquivilantException> GetIEnumerableInstance() { return new List<NoReStAPIEquivilantException> {GetInstance()}; }

        internal static NoReStAPIEquivilantException GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new NoReStAPIEquivilantException();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetObjectData_PostValidate(NoReStAPIEquivilantException instance, SerializationInfo info, StreamingContext context);
        partial void GetObjectData_PreCondition(NoReStAPIEquivilantException instance, ref SerializationInfo info, ref StreamingContext context);
        partial void GetType_PostValidate(NoReStAPIEquivilantException instance, Type _retVal);
        partial void GetType_PreCondition(NoReStAPIEquivilantException instance);
        partial void HResult_SetCondition(ref NoReStAPIEquivilantException instance, ref Int32 setValue);

        partial void HelpLink_SetCondition(ref NoReStAPIEquivilantException instance, ref String setValue);
        partial void InnerException_SetCondition(ref NoReStAPIEquivilantException instance, ref Exception setValue);
        static partial void InstanceFactory(ref NoReStAPIEquivilantException instance, [CallerMemberName] string callerName = "");
        partial void Message_SetCondition(ref NoReStAPIEquivilantException instance, ref String setValue);

        partial void Source_SetCondition(ref NoReStAPIEquivilantException instance, ref String setValue);
        partial void StackTrace_SetCondition(ref NoReStAPIEquivilantException instance, ref String setValue);
        partial void TargetSite_SetCondition(ref NoReStAPIEquivilantException instance, ref MethodBase setValue);
        partial void ToString_PostValidate(NoReStAPIEquivilantException instance, String _retVal);
        partial void ToString_PreCondition(NoReStAPIEquivilantException instance);
    }
}