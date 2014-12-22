using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.OriginalManualTfs.APIs
{
    /// <summary>
    ///     Class TeamRoomAPI_UnitTests.
    /// </summary>
    [TestClass]
    public class TeamRoomAPI_UnitTests
    {
        /// <summary>
        ///     Creates the team room_ unit test.
        /// </summary>
        [TestMethod]
        public void CreateTeamRoom_UnitTest()
        {
            var api = new TeamRoomAPI();

            string name = String.Format("Test Room {0}", DateTime.UtcNow.Ticks);
            const string description = "Dummy Room Created by Unit Test";
            Task<ITeamRoom> loadTask = api.CreateRoom(name, description);
            ITeamRoom teamRoom = loadTask.Result;
            Assert.IsNotNull(teamRoom);
        }

        /// <summary>
        ///     Gets the team rooms_ unit test.
        /// </summary>
        [TestMethod]
        public void GetTeamRooms_UnitTest()
        {
            var api = new TeamRoomAPI();

            Task<IReadOnlyList<ITeamRoom>> loadTask = api.GetTeamRooms();
            IReadOnlyList<ITeamRoom> teamRooms = loadTask.Result;
            Assert.IsNotNull(teamRooms);
            Assert.IsTrue(teamRooms.Count > 0);
        }
    }
}