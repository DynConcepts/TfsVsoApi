using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    /// <summary>
    ///     Class TeamRoomAPI.
    /// </summary>
    internal class TeamRoomAPI : VsoRestAPIBase, ITeamRoomAPI
    {
        /// <summary>
        ///     Creates the room.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <returns>Task&lt;ITeamRoom&gt;.</returns>
        public async Task<ITeamRoom> CreateRoom(string name, string description)
        {
            const string request = "/chat/rooms";
            const string format = " \"name\": \"{0}\", \"description\": \"{1}\", ";
            string body = "{" + String.Format(format, name, description) + "}";
            ITeamRoom result = await ProcessCollectionPostRequest(request, body, o => JsonParsers.JObjectToInstance(o, JsonTeamRoom.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the team rooms.
        /// </summary>
        /// <returns>Task&lt;IList&lt;ITeamRoom&gt;&gt;.</returns>
        public async Task<IReadOnlyList<ITeamRoom>> GetTeamRooms()
        {
            const string request = "/chat/rooms";
            IReadOnlyList<ITeamRoom> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, JsonTeamRoom.FromToken));
            return result;
        }
    }
}