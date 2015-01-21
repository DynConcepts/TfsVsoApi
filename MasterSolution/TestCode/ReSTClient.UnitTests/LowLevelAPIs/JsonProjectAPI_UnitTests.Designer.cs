using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonProjectAPI_UnitTests : DynTestClassBase
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
        public void GetProjectTeamMembers_UnitTest()
        {
            Guid projectId = default(Guid);
            Guid teamId = default(Guid);
            Task<IReadOnlyList<JsonProjectTeamMember>> _retVal = default(Task<IReadOnlyList<JsonProjectTeamMember>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    projectId = default(Guid); //No Constructor
                    teamId = default(Guid); //No Constructor
                    GetProjectTeamMembers_PreCondition(instance, ref projectId, ref teamId);
                },
                instance => { return _retVal = instance.GetProjectTeamMembers(projectId, teamId); },
                instance => { GetProjectTeamMembers_PostValidate(instance, projectId, teamId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProjectTeam_UnitTest()
        {
            Guid projectId = default(Guid);
            Guid teamId = default(Guid);
            Task<JsonProjectTeam> _retVal = default(Task<JsonProjectTeam>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    projectId = default(Guid); //No Constructor
                    teamId = default(Guid); //No Constructor
                    GetProjectTeam_PreCondition(instance, ref projectId, ref teamId);
                },
                instance => { return _retVal = instance.GetProjectTeam(projectId, teamId); },
                instance => { GetProjectTeam_PostValidate(instance, projectId, teamId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProjectTeams_UnitTest()
        {
            Guid projectId = default(Guid);
            Task<IReadOnlyList<JsonProjectTeam>> _retVal = default(Task<IReadOnlyList<JsonProjectTeam>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    projectId = default(Guid); //No Constructor
                    GetProjectTeams_PreCondition(instance, ref projectId);
                },
                instance => { return _retVal = instance.GetProjectTeams(projectId); },
                instance => { GetProjectTeams_PostValidate(instance, projectId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProject_UnitTest()
        {
            Guid projectId = default(Guid);
            Task<JsonProject> _retVal = default(Task<JsonProject>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    projectId = default(Guid); //No Constructor
                    GetProject_PreCondition(instance, ref projectId);
                },
                instance => { return _retVal = instance.GetProject(projectId); },
                instance => { GetProject_PostValidate(instance, projectId, _retVal); });
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

        partial void Equals_PostValidate(JsonProjectAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonProjectAPI instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonProjectAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonProjectAPI instance);
        internal static IEnumerable<JsonProjectAPI> GetIEnumerableInstance() { return new List<JsonProjectAPI> {GetInstance()}; }

        internal static JsonProjectAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonProjectAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetProjectTeamMembers_PostValidate(JsonProjectAPI instance, Guid projectId, Guid teamId, Task<IReadOnlyList<JsonProjectTeamMember>> _retVal);
        partial void GetProjectTeamMembers_PreCondition(JsonProjectAPI instance, ref Guid projectId, ref Guid teamId);
        partial void GetProjectTeam_PostValidate(JsonProjectAPI instance, Guid projectId, Guid teamId, Task<JsonProjectTeam> _retVal);
        partial void GetProjectTeam_PreCondition(JsonProjectAPI instance, ref Guid projectId, ref Guid teamId);
        partial void GetProjectTeams_PostValidate(JsonProjectAPI instance, Guid projectId, Task<IReadOnlyList<JsonProjectTeam>> _retVal);
        partial void GetProjectTeams_PreCondition(JsonProjectAPI instance, ref Guid projectId);
        partial void GetProject_PostValidate(JsonProjectAPI instance, Guid projectId, Task<JsonProject> _retVal);
        partial void GetProject_PreCondition(JsonProjectAPI instance, ref Guid projectId);
        partial void GetProjects_PostValidate(JsonProjectAPI instance, Task<IReadOnlyList<JsonProject>> _retVal);
        partial void GetProjects_PreCondition(JsonProjectAPI instance);

        partial void GetType_PostValidate(JsonProjectAPI instance, Type _retVal);
        partial void GetType_PreCondition(JsonProjectAPI instance);
        static partial void InstanceFactory(ref JsonProjectAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonProjectAPI instance, String _retVal);
        partial void ToString_PreCondition(JsonProjectAPI instance);
    }
}