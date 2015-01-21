using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.RestCalls;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    ///     Class JsonChatAPI.
    /// </summary>
    internal class JsonChatAPI : VsoRestAPIBase
    {
        /// <summary>
        /// Gets the messages.
        /// </summary>
        /// <param name="roomId">The room identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonRoomMember&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonRoomMessage>> GetMessages(string roomId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ChatRestCalls.Messages);
            exchange.SetRoute("{roomId}", roomId);
            IReadOnlyList<JsonRoomMessage> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonRoomMessage.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the rooms.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonRoom>> GetRooms()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ChatRestCalls.Rooms);
            IReadOnlyList<JsonRoom> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonRoom.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <param name="roomId">The room identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonRoomMember&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonRoomMember>> GetUsers(string roomId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ChatRestCalls.Users);
            exchange.SetRoute("{roomId}", roomId);
            IReadOnlyList<JsonRoomMember> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonRoomMember.FromToken));
            return result;
        }
    }
}