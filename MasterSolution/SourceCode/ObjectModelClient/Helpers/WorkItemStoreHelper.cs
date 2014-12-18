using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
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
        public IWorkItemOM GetWorkItem(int id) { return WorkItemWrapper.GetWrapper(r_Instance.GetWorkItem(id)); }

        public WorkItemCollection Query(string wiql) { return r_Instance.Query(wiql); }

        /// <summary>
        ///     Gets the projects.
        /// </summary>
        /// <value>The projects.</value>
        public Dictionary<String, Project> Projects { get { return r_Instance.Projects.Cast<Project>().ToDictionary(o => o.Name); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemStoreHelper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public WorkItemStoreHelper(WorkItemStore instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly WorkItemStore r_Instance;
    }
}