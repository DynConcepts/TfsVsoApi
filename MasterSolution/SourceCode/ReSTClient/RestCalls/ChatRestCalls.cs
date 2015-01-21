using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class ChatRestCalls.
    /// </summary>
    internal class ChatRestCalls
    {
        /*
/chat/rooms/{roomId}/messages		GET		_apis/chat/rooms/305/messages?api-version=1.0
/chat/rooms/{roomId}/messages/{messageId}		GET		_apis/chat/rooms/305/messages/118943?api-version=1.0
/chat/rooms/{roomId}/messages/{messageId}		PATCH		_apis/chat/rooms/305/messages/118943?api-version=1.0
/chat/rooms/{roomId}/messages		POST		_apis/chat/rooms/305/messages?api-version=1.0
/chat/rooms/{roomId}		DELETE		_apis/chat/rooms/12797?api-version=1.0
/chat/rooms		GET		_apis/chat/rooms?api-version=1.0
/chat/rooms/{roomId}		GET		_apis/chat/rooms/12797?api-version=1.0
/chat/rooms/{roomId}		PATCH		_apis/chat/rooms/12797?api-version=1.0
/chat/rooms		POST		_apis/chat/rooms?api-version=1.0
/chat/rooms/{roomId}/users/{userId}		DELETE		_apis/chat/rooms/305/users/d6245f20-2af8-44f4-9451-8107cb2767db?api-version=1.0
/chat/rooms/{roomId}/users		GET		_apis/chat/rooms/305/users?api-version=1.0
/chat/rooms/{roomId}/users/{userId}		GET		_apis/chat/rooms/305/users/d6245f20-2af8-44f4-9451-8107cb2767db?api-version=1.0
/chat/rooms/{roomId}/users/{userId}		PUT		_apis/chat/rooms/305/users/d6245f20-2af8-44f4-9451-8107cb2767db?api-version=1.0
*/
        /// <summary>
        ///     Gets the messages.
        /// </summary>
        /// <value>The messages.</value>
        internal static CallSpec Messages { get { return sr_Messages; } }

        /// <summary>
        ///     Gets the rooms.
        /// </summary>
        /// <value>The rooms.</value>
        internal static CallSpec Rooms { get { return sr_Rooms; } }

        /// <summary>
        ///     Gets the users.
        /// </summary>
        /// <value>The users.</value>
        internal static CallSpec Users { get { return sr_Users; } }

        /// <summary>
        ///     The SR_ messages
        /// </summary>
        private static readonly CallSpec sr_Messages = new CallSpec("_apis/Chat/Rooms/{roomId}/Messages");
        private static readonly CallSpec sr_Message = new CallSpec("_apis/Chat/Rooms/{roomId}/Messages/{messageId}");

        /// <summary>
        ///     The SR_ rooms
        /// </summary>
        private static readonly CallSpec sr_Rooms = new CallSpec("_apis/Chat/Rooms");
        private static readonly CallSpec sr_Room = new CallSpec("_apis/Chat/Rooms/{roomId}");

        /// <summary>
        ///     The SR_ users
        /// </summary>
        private static readonly CallSpec sr_Users = new CallSpec("_apis/Chat/Rooms/{roomId}/Users");
        private static readonly CallSpec sr_User = new CallSpec("_apis/Chat/Rooms/{roomId}/Users/{userId}");
    }
}