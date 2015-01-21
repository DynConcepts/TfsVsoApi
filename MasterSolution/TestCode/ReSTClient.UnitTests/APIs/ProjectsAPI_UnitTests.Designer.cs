using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ProjectsAPI_UnitTests : DynTestClassBase
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
        public void GetProjects_UnitTest()
        {
            Task<IReadOnlyList<JsonProject>> _retVal = default(Task<IReadOnlyList<JsonProject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetProjects_PreCondition(instance); },
                instance => { return _retVal = instance.GetProjects(); },
                instance => { GetProjects_PostValidate(instance, _retVal); });
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

        partial void Equals_PostValidate(ProjectsAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ProjectsAPI instance, ref Object obj);

        partial void GetHashCode_PostValidate(ProjectsAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ProjectsAPI instance);
        internal static IEnumerable<ProjectsAPI> GetIEnumerableInstance() { return new List<ProjectsAPI> {GetInstance()}; }

        internal static ProjectsAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ProjectsAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetProjects_PostValidate(ProjectsAPI instance, Task<IReadOnlyList<JsonProject>> _retVal);
        partial void GetProjects_PreCondition(ProjectsAPI instance);

        partial void GetType_PostValidate(ProjectsAPI instance, Type _retVal);
        partial void GetType_PreCondition(ProjectsAPI instance);
        static partial void InstanceFactory(ref ProjectsAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(ProjectsAPI instance, String _retVal);
        partial void ToString_PreCondition(ProjectsAPI instance);
    }
}