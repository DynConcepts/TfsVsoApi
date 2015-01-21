using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonBackedDataBase_UnitTests : DynTestClassBase
    {
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
        public void MakeToken_UnitTest()
        {
            object value = default(object);
            JToken _retVal = default(JToken);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { MakeToken_PreCondition(ref instance, ref value); },
                instance => { _retVal = JsonBackedDataBase.MakeToken(value); },
                instance => { MakeToken_PostValidate(instance, value, _retVal); });
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

        partial void Equals_PostValidate(JsonBackedDataBase instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonBackedDataBase instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonBackedDataBase instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonBackedDataBase instance);

        internal static IEnumerable<JsonBackedDataBase> GetIEnumerableInstance()
        {
            return new List<JsonBackedDataBase> {GetInstance()};
        }

        internal static JsonBackedDataBase GetInstance([CallerMemberName] string callerName = "")
        {
            JsonBackedDataBase instance = default(JsonBackedDataBase);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonBackedDataBase instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonBackedDataBase instance);
        static partial void InstanceFactory(ref JsonBackedDataBase instance, [CallerMemberName] string callerName = "");
        partial void MakeToken_PostValidate<TValue>(JsonBackedDataBase instance, TValue value, JToken _retVal);
        partial void MakeToken_PreCondition<TValue>(ref JsonBackedDataBase instance, ref TValue value);
        partial void ToString_PostValidate(JsonBackedDataBase instance, String _retVal);
        partial void ToString_PreCondition(ref JsonBackedDataBase instance);
    }
}