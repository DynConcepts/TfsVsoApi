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
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetBaseException_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetBaseException_PreCondition(ref instance); },
                instance => { instance.GetBaseException(); },
                instance => { GetBaseException_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance); });
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
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { instance.GetType(); },
                instance => { GetType_PostValidate(instance); });
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
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { instance.ToString(); },
                instance => { ToString_PostValidate(instance); });
        }

        partial void Data_SetCondition(ref NoReStAPIEquivilantException instance, ref IDictionary setValue);
        partial void Equals_PostValidate(NoReStAPIEquivilantException instance, Object obj);
        partial void Equals_PreCondition(ref NoReStAPIEquivilantException instance, ref Object obj);
        partial void GetBaseException_PostValidate(NoReStAPIEquivilantException instance);
        partial void GetBaseException_PreCondition(ref NoReStAPIEquivilantException instance);
        partial void GetHashCode_PostValidate(NoReStAPIEquivilantException instance);
        partial void GetHashCode_PreCondition(ref NoReStAPIEquivilantException instance);
        internal static IEnumerable<NoReStAPIEquivilantException> GetIEnumerableInstance() { return new List<NoReStAPIEquivilantException> {GetInstance()}; }

        internal static NoReStAPIEquivilantException GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new NoReStAPIEquivilantException();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetObjectData_PostValidate(NoReStAPIEquivilantException instance, SerializationInfo info, StreamingContext context);
        partial void GetObjectData_PreCondition(ref NoReStAPIEquivilantException instance, ref SerializationInfo info, ref StreamingContext context);
        partial void GetType_PostValidate(NoReStAPIEquivilantException instance);
        partial void GetType_PreCondition(ref NoReStAPIEquivilantException instance);
        partial void HResult_SetCondition(ref NoReStAPIEquivilantException instance, ref Int32 setValue);

        partial void HelpLink_SetCondition(ref NoReStAPIEquivilantException instance, ref String setValue);
        partial void InnerException_SetCondition(ref NoReStAPIEquivilantException instance, ref Exception setValue);
        static partial void InstanceFactory(ref NoReStAPIEquivilantException instance, [CallerMemberName] string callerName = "");
        partial void Message_SetCondition(ref NoReStAPIEquivilantException instance, ref String setValue);

        partial void Source_SetCondition(ref NoReStAPIEquivilantException instance, ref String setValue);
        partial void StackTrace_SetCondition(ref NoReStAPIEquivilantException instance, ref String setValue);
        partial void TargetSite_SetCondition(ref NoReStAPIEquivilantException instance, ref MethodBase setValue);
        partial void ToString_PostValidate(NoReStAPIEquivilantException instance);
        partial void ToString_PreCondition(ref NoReStAPIEquivilantException instance);
    }
}