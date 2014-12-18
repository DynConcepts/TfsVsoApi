using System;
using System.Reflection;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.Factories
{
    /// <summary>
    ///     Class APIFactory.
    /// </summary>
    public static class APIFactory
    {
   
        /// <summary>
        ///     Gets the work item API.
        /// </summary>
        /// <value>The work item API.</value>
        public static JsonWorkItemAPI JsonWorkItemAPI { get { return new JsonWorkItemAPI(); } }

        /// <summary>
        /// Gets the TFS version control API.
        /// </summary>
        /// <value>The TFS version control API.</value>
        public static ITFSVersionControlAPI TFSVersionControlAPI { get { return new TFSVersionControlAPI(); } }

        /// <summary>
        /// Connects the specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>ITfsTeamProjectCollection.</returns>
        public static ITfsTeamProjectCollection Connect(Uri url)
        {
            JsonWorkItem.APIFactory = () => new JsonWorkItemAPI();
            return new TfsTeamProjectCollectionImpl(url);
        }

    }
}