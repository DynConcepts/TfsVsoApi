using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFSExtra;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.APIs
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
            const string format = " \"name\": \"{0}\", \"description\": \"{1}\", ";
            string body = "{" + String.Format(format, name, description) + "}";
            var exchange = StructuredHttpExchange.Post("/chat/rooms",body);
            ITeamRoom result = await ProcessCollectionRequest(exchange, o => JsonParsers.JObjectToInstance(o, TeamRoomImpl.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the team rooms.
        /// </summary>
        /// <returns>Task&lt;IList&lt;ITeamRoom&gt;&gt;.</returns>
        public async Task<IReadOnlyList<ITeamRoom>> GetTeamRooms()
        {
            var exchange = StructuredHttpExchange.Get("/chat/rooms");
            IReadOnlyList<ITeamRoom> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, TeamRoomImpl.FromToken));
            return result;
        }
    }
}