using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;

namespace DynCon.OSI.VSO.SharedInterfaces.APIs
{
    /// <summary>
    ///     Interface ITeamRoomAPI
    /// </summary>
    public interface ITeamRoomAPI
    {
        /// <summary>
        ///     Creates the room.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <returns>Task&lt;ITeamRoom&gt;.</returns>
        Task<ITeamRoom> CreateRoom(string name, string description);

        /// <summary>
        ///     Gets the team rooms.
        /// </summary>
        /// <returns>Task&lt;IList&lt;ITeamRoom&gt;&gt;.</returns>
        Task<IReadOnlyList<ITeamRoom>> GetTeamRooms();
    }
}