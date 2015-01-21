using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TeamRoomAPI_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreateRoom_UnitTest()
        {
            String name = default(String);
            String description = default(String);
            Task<ITeamRoom> _retVal = default(Task<ITeamRoom>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    description = default(String); //No Constructor
                    CreateRoom_PreCondition(instance, ref name, ref description);
                },
                instance => { return _retVal = instance.CreateRoom(name, description); },
                instance => { CreateRoom_PostValidate(instance, name, description, _retVal); });
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
        public void GetTeamRooms_UnitTest()
        {
            Task<IReadOnlyList<ITeamRoom>> _retVal = default(Task<IReadOnlyList<ITeamRoom>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetTeamRooms_PreCondition(instance); },
                instance => { return _retVal = instance.GetTeamRooms(); },
                instance => { GetTeamRooms_PostValidate(instance, _retVal); });
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

        partial void CreateRoom_PostValidate(TeamRoomAPI instance, String name, String description, Task<ITeamRoom> _retVal);
        partial void CreateRoom_PreCondition(TeamRoomAPI instance, ref String name, ref String description);

        partial void Equals_PostValidate(TeamRoomAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(TeamRoomAPI instance, ref Object obj);

        partial void GetHashCode_PostValidate(TeamRoomAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(TeamRoomAPI instance);
        internal static IEnumerable<TeamRoomAPI> GetIEnumerableInstance() { return new List<TeamRoomAPI> {GetInstance()}; }

        internal static TeamRoomAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TeamRoomAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetTeamRooms_PostValidate(TeamRoomAPI instance, Task<IReadOnlyList<ITeamRoom>> _retVal);
        partial void GetTeamRooms_PreCondition(TeamRoomAPI instance);

        partial void GetType_PostValidate(TeamRoomAPI instance, Type _retVal);
        partial void GetType_PreCondition(TeamRoomAPI instance);
        static partial void InstanceFactory(ref TeamRoomAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(TeamRoomAPI instance, String _retVal);
        partial void ToString_PreCondition(TeamRoomAPI instance);
    }
}