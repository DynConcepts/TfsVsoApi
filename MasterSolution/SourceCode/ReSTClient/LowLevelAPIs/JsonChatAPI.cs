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
        ///     Gets the messages.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetMessages()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ChatRestCalls.Messages);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
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
        ///     Gets the users.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetUsers()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ChatRestCalls.Users);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }
    }
}