using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    /// <summary>
    /// Class TfsTeamProjectCollectionImpl.
    /// </summary>
    internal class TfsTeamProjectCollectionImpl : TfsConnectionImpl, ITfsTeamProjectCollection
    {
        private readonly Uri r_Uri;

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsTeamProjectCollectionImpl"/> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        internal TfsTeamProjectCollectionImpl(Uri uri) { r_Uri = uri; }

        /// <summary>
        /// Gets the configuration server.
        /// </summary>
        /// <value>The configuration server.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ITfsConfigurationServer ITfsTeamProjectCollection.ConfigurationServer { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String ITfsTeamProjectCollection.DisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        /// <summary>
        /// Gets the team foundation server.
        /// </summary>
        /// <value>The team foundation server.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ITeamFoundationServer ITfsTeamProjectCollection.TeamFoundationServer { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}