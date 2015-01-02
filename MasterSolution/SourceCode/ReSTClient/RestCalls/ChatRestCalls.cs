using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class ChatRestCalls.
    /// </summary>
    internal class ChatRestCalls
    {
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
        private static readonly CallSpec sr_Messages = new CallSpec("_apis/Chat/{parentresource}/{roomId}/Messages/{messageId}");

        /// <summary>
        ///     The SR_ rooms
        /// </summary>
        private static readonly CallSpec sr_Rooms = new CallSpec("_apis/Chat/Rooms/{roomId}");

        /// <summary>
        ///     The SR_ users
        /// </summary>
        private static readonly CallSpec sr_Users = new CallSpec("_apis/Chat/{parentresource}/{roomId}/Users/{userId}");
    }
}