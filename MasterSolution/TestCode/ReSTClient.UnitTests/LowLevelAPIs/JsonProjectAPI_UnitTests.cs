using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonProjectAPI_UnitTests : DynTestClassBase
    {
        partial void GetProjectTeamMembers_PostValidate(JsonProjectAPI instance, Guid projectId, Guid teamId, Task<IReadOnlyList<JsonProjectTeamMember>> _retVal) { if (!_retVal.IsCompleted) throw new Exception(); }

        partial void GetProjectTeamMembers_PreCondition(JsonProjectAPI instance, ref Guid projectId, ref Guid teamId)
        {
            projectId = Guid.Parse("489bf70d-20ff-4f9b-8ce4-4f12f331d0b5");
            teamId = Guid.Parse(" 4ae176ed-a71c-417d-a33c-96a004fef678");
        }
        partial void GetProjectTeam_PostValidate(JsonProjectAPI instance, Guid projectId, Guid teamId, Task<JsonProjectTeam> _retVal) { if (!_retVal.IsCompleted) throw new Exception(); }

        partial void GetProjectTeam_PreCondition(JsonProjectAPI instance, ref Guid projectId, ref Guid teamId)
        {
            projectId = Guid.Parse("489bf70d-20ff-4f9b-8ce4-4f12f331d0b5");
            teamId = Guid.Parse(" 4ae176ed-a71c-417d-a33c-96a004fef678");

        }
        partial void GetProjectTeams_PostValidate(JsonProjectAPI instance, Guid projectId, Task<IReadOnlyList<JsonProjectTeam>> _retVal) { if (!_retVal.IsCompleted) throw new Exception(); }
        partial void GetProjectTeams_PreCondition(JsonProjectAPI instance, ref Guid projectId){ projectId = Guid.Parse("489bf70d-20ff-4f9b-8ce4-4f12f331d0b5"); }
        partial void GetProject_PostValidate(JsonProjectAPI instance, Guid projectId, Task<JsonProject> _retVal) { if (!_retVal.IsCompleted) throw new Exception(); }
        partial void GetProject_PreCondition(JsonProjectAPI instance, ref Guid projectId){projectId = Guid.Parse("489bf70d-20ff-4f9b-8ce4-4f12f331d0b5"); }
        partial void GetProjects_PostValidate(JsonProjectAPI instance, Task<IReadOnlyList<JsonProject>> _retVal) { if (!_retVal.IsCompleted) throw new Exception(); }

    }
}
