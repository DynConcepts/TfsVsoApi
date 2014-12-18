using System;
using System.Reflection;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.APIs;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.Factories
{
    /// <summary>
    ///     Class APIFactory.
    /// </summary>
    public static class APIFactory
    {
        static APIFactory()
        {
            MappedObjectInitializer.ForceInitialize(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        ///     Connects the specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>ITfsTeamProjectCollectionWrapper.</returns>
        public static ITfsTeamProjectCollection Connect(Uri url)
        {
            var real = new TfsTeamProjectCollection(url);
            return TfsTeamProjectCollectionWrapper.GetWrapper(real);
        }

        /// <summary>
        ///     Gets the TFS version control API.
        /// </summary>
        /// <value>The TFS version control API.</value>
        public static ITFSVersionControlAPI TFSVersionControlAPI { get { return new TFSVersionControlAPI(); } }

        /// <summary>
        ///     Gets the work item API.
        /// </summary>
        /// <value>The work item API.</value>
        public static IWorkItemAPI WorkItemAPI { get { return new WorkItemAPI(); } }
    }
}