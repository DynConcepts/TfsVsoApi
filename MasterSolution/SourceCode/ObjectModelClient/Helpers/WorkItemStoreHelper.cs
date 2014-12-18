using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations.WIT;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.Helpers
{
    /// <summary>
    ///     Class WorkItemStoreHelper.
    /// </summary>
    internal class WorkItemStoreHelper 
    {
        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>WorkItemWrapper.</returns>
        internal IWorkItem GetWorkItem(int id) { return WorkItemWrapper.GetWrapper(r_Instance.GetWorkItem(id)); }

        /// <summary>
        /// Queries the specified wiql.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <returns>WorkItemCollection.</returns>
        internal WorkItemCollection Query(string wiql) { return r_Instance.Query(wiql); }

        /// <summary>
        ///     Gets the projects.
        /// </summary>
        /// <value>The projects.</value>
        internal Dictionary<String, Project> Projects { get { return r_Instance.Projects.Cast<Project>().ToDictionary(o => o.Name); } }


        /// <summary>
        /// Gets the om project.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Project.</returns>
        internal Project GetOMProject(string projectName) { return r_Instance.Projects[projectName]; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemStoreHelper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        internal WorkItemStoreHelper(WorkItemStore instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly WorkItemStore r_Instance;
    }
}