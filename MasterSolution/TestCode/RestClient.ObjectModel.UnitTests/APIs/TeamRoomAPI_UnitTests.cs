using System;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.APIs;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    public partial class TeamRoomAPI_UnitTests : DynTestClassBase
    {
        partial void CreateRoom_PreCondition(TeamRoomAPI instance, ref String name, ref String description)
        {
            name = "Test Room: " + Guid.NewGuid().ToByteArray();
            description = "Team Room Created During Unit Testing";
        }

    }
}