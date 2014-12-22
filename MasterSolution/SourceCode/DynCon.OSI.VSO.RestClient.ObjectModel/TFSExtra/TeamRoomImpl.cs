using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFSExtra
{
    class TeamRoomImpl : JsonTeamRoom, ITeamRoom 
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <returns>ITeamRoom.</returns>
        public new static TeamRoomImpl FromToken(JToken arg)
        {
            var teamRoom = new TeamRoomImpl(arg);
            return teamRoom;
        }

        public TeamRoomImpl(JToken json)
            : base(json)
        {
        }
    }
}
