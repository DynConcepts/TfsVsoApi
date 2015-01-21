using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.APIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TFSVersionControlAPI_UnitTests : DynTestClassBase
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
                    Equals_PreCondition(instance, ref obj);
                },
                instance => { return _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
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
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Equals_PostValidate(TFSVersionControlAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(TFSVersionControlAPI instance, ref Object obj);

        partial void GetHashCode_PostValidate(TFSVersionControlAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(TFSVersionControlAPI instance);
        internal static IEnumerable<TFSVersionControlAPI> GetIEnumerableInstance() { return new List<TFSVersionControlAPI> {GetInstance()}; }

        internal static TFSVersionControlAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TFSVersionControlAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(TFSVersionControlAPI instance, Type _retVal);
        partial void GetType_PreCondition(TFSVersionControlAPI instance);
        static partial void InstanceFactory(ref TFSVersionControlAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(TFSVersionControlAPI instance, String _retVal);
        partial void ToString_PreCondition(TFSVersionControlAPI instance);
    }
}