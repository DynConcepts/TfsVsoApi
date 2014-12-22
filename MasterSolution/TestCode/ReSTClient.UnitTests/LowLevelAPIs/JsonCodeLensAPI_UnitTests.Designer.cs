using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonCodeLensAPI_UnitTests : DynTestClassBase
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
        public void GetDetails_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetDetails_PreCondition(ref instance); },
                instance => { _retVal = instance.GetDetails(); },
                instance => { GetDetails_PostValidate(instance, _retVal); });
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
        public void GetSummaries_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetSummaries_PreCondition(ref instance); },
                instance => { _retVal = instance.GetSummaries(); },
                instance => { GetSummaries_PostValidate(instance, _retVal); });
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
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Equals_PostValidate(JsonCodeLensAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonCodeLensAPI instance, ref Object obj);
        partial void GetDetails_PostValidate(JsonCodeLensAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetDetails_PreCondition(ref JsonCodeLensAPI instance);

        partial void GetHashCode_PostValidate(JsonCodeLensAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonCodeLensAPI instance);
        internal static IEnumerable<JsonCodeLensAPI> GetIEnumerableInstance() { return new List<JsonCodeLensAPI> {GetInstance()}; }

        internal static JsonCodeLensAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonCodeLensAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetSummaries_PostValidate(JsonCodeLensAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetSummaries_PreCondition(ref JsonCodeLensAPI instance);

        partial void GetType_PostValidate(JsonCodeLensAPI instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonCodeLensAPI instance);
        static partial void InstanceFactory(ref JsonCodeLensAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonCodeLensAPI instance, String _retVal);
        partial void ToString_PreCondition(ref JsonCodeLensAPI instance);
    }
}