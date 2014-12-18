using System;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.APIs
{
    /// <summary>
    ///     Class ClientObjectModelBasedAPI.
    /// </summary>
    internal class ClientObjectModelBasedAPI
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ClientObjectModelBasedAPI" /> class.
        /// </summary>
        protected ClientObjectModelBasedAPI() { r_Tpc = Connect(); }


        /// <summary>
        ///     Asynchronouses the operation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected Task<T> AsyncOperation<T>(Func<T> func)
        {
            var task = new Task<T>(() =>
            {
                T result = func();
                return result;
            });
            task.Start();
            return task;
        }

        /// <summary>
        ///     Connects this instance.
        /// </summary>
        /// <returns>ITfsTeamProjectCollection.</returns>
        private TfsTeamProjectCollection Connect()
        {
            // Connect to the work item store
            var tpc = new TfsTeamProjectCollection(TeamProjectCollection);
            tpc.EnsureAuthenticated();
            return tpc;
        }

        /// <summary>
        ///     Works the item store.
        /// </summary>
        /// <returns>WorkItemStore.</returns>
        protected IWorkItemStore WorkItemStore()
        {
            var workItemStore = r_Tpc.GetService<WorkItemStore>();
            return WorkItemStoreWrapper.GetWrapper(workItemStore);
        }

        //protected VersionControlServerHelper VersionControl()
        //{
        //    var versionControlServer = r_Tpc.GetService<VersionControlServer>();
        //    return new VersionControlServer Helper(versionControlServer);
        //}


        /// <summary>
        ///     Gets or sets the team project collection.
        /// </summary>
        /// <value>The team project collection.</value>
        private static Uri TeamProjectCollection { get { return s_TeamProjectCollection; } set { s_TeamProjectCollection = value; } }

        /// <summary>
        ///     The _team project collection
        /// </summary>
        private static Uri s_TeamProjectCollection = new Uri("*****");// TODO Put in appropriate value, then refactor

        /// <summary>
        ///     The _TPC
        /// </summary>
        private readonly TfsTeamProjectCollection r_Tpc;
    }
}