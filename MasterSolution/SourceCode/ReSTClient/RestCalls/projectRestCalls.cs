using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class ProjectRestCalls.
    /// </summary>
    internal class ProjectRestCalls
    {
        /*
/projectCollections		                        GET		_apis/projectCollections?api-version=1.0-preview.2
/projectCollections/{collectionId}		        GET		_apis/projectCollections/d81542e4-cdfa-4333-b082-1ae2d6c3ad16?api-version=1.0-preview.2
/projects		                                GET		_apis/projects?api-version=1.0
/projects/{projectId}	                        GET		_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1?stateFilter=All&api-version=1.0
/projects/{projectName}		                    GET		_apis/projects/Fabrikam-Fiber-TFVC?api-version=1.0
/projects/{projectId}		                    PATCH	_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1?api-version=1.0
/projects/{projectId}/teams		                GET		_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1/teams?api-version=1.0
/projects/{projectId}/teams/{teamId}	    	GET		_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1/teams/564e8204-a90b-4432-883b-d4363c6125ca?api-version=1.0
/projects/{projectId}/teams/{teamId}/members/	GET		_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1/teams/564e8204-a90b-4432-883b-d4363c6125ca/members/?api-version=1.0
        */

        /// <summary>
        ///     Gets the project by identifier.
        /// </summary>
        /// <value>The project by identifier.</value>
        internal static CallSpec ProjectById { get { return sr_ProjectById; } }

        /// <summary>
        ///     Gets the name of the project by.
        /// </summary>
        /// <value>The name of the project by.</value>
        internal static CallSpec ProjectByName { get { return sr_ProjectByName; } }

        /// <summary>
        ///     Gets the project team.
        /// </summary>
        /// <value>The project team.</value>
        internal static CallSpec ProjectTeam { get { return sr_ProjectTeam; } }

        /// <summary>
        ///     Gets the project team members.
        /// </summary>
        /// <value>The project team members.</value>
        internal static CallSpec ProjectTeamMembers { get { return sr_ProjectTeamMembers; } }

        /// <summary>
        ///     Gets the project teams.
        /// </summary>
        /// <value>The project teams.</value>
        internal static CallSpec ProjectTeams { get { return sr_ProjectTeams; } }

        /// <summary>
        ///     Gets the projects.
        /// </summary>
        /// <value>The projects.</value>
        internal static CallSpec Projects { get { return sr_Projects; } }

        /// <summary>
        ///     The SR_ project by identifier
        /// </summary>
        private static readonly CallSpec sr_ProjectById = new CallSpec("_apis//projects/{projectId}");

        /// <summary>
        ///     The SR_ project by name
        /// </summary>
        private static readonly CallSpec sr_ProjectByName = new CallSpec("_apis//projects/{projectName}");

        /// <summary>
        ///     The SR_ project team
        /// </summary>
        private static readonly CallSpec sr_ProjectTeam = new CallSpec("_apis//projects/{projectId}/teams/{teamId}");

        /// <summary>
        ///     The SR_ project team members
        /// </summary>
        private static readonly CallSpec sr_ProjectTeamMembers = new CallSpec("_apis//projects/{projectId}/teams/{teamId}/members");

        /// <summary>
        ///     The SR_ project teams
        /// </summary>
        private static readonly CallSpec sr_ProjectTeams = new CallSpec("_apis//projects/{projectId}/teams");

        /// <summary>
        ///     The SR_ projects
        /// </summary>
        private static readonly CallSpec sr_Projects = new CallSpec("_apis/projects");
    }
}