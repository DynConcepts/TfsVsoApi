using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.Core.ObjectMapping
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class MappedObjectBase_UnitTests : DynTestClassBase
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
                instance => { Equals_PostValidate(ref instance, obj, _retVal); });
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
                instance => { GetHashCode_PostValidate(ref instance, _retVal); });
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
                instance => { GetType_PostValidate(ref instance, _retVal); });
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
                instance => { ToString_PostValidate(ref instance, _retVal); });
        }

        partial void Equals_PostValidate(ref MappedObjectBase instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref MappedObjectBase instance, ref Object obj);

        partial void GetHashCode_PostValidate(ref MappedObjectBase instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref MappedObjectBase instance);
        internal static IEnumerable<MappedObjectBase> GetIEnumerableInstance() { return new List<MappedObjectBase> {GetInstance()}; }

        internal static MappedObjectBase GetInstance([CallerMemberName] string callerName = "")
        {
            MappedObjectBase instance = default(MappedObjectBase);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(ref MappedObjectBase instance, Type _retVal);
        partial void GetType_PreCondition(ref MappedObjectBase instance);
        static partial void InstanceFactory(ref MappedObjectBase instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(ref MappedObjectBase instance, String _retVal);
        partial void ToString_PreCondition(ref MappedObjectBase instance);
    }
}