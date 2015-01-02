using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class TfsTeamProjectCollectionImpl.
    /// </summary>
    public class TfsTeamProjectCollectionImpl : TfsConnectionImpl, ITfsTeamProjectCollection
    {
        /// <summary>
        ///     Gets the configuration server.
        /// </summary>
        /// <value>The configuration server.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ITfsConfigurationServer ITfsTeamProjectCollection.ConfigurationServer { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String ITfsTeamProjectCollection.DisplayName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the team foundation server.
        /// </summary>
        /// <value>The team foundation server.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ITeamFoundationServer ITfsTeamProjectCollection.TeamFoundationServer { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TfsTeamProjectCollectionImpl" /> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public TfsTeamProjectCollectionImpl(Uri uri) { r_Uri = uri; }

        private readonly Uri r_Uri;
    }
}