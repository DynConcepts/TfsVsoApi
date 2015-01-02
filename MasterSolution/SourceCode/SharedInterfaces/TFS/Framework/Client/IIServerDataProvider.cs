using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface IIServerDataProvider
    /// </summary>
    public interface IIServerDataProvider : IILocationService
    {
        /// <summary>
        /// Authenticates this instance.
        /// </summary>
        void Authenticate();
        /// <summary>
        /// Connects the specified connect options.
        /// </summary>
        /// <param name="connectOptions">The connect options.</param>
        void Connect(IConnectOptions connectOptions);
        /// <summary>
        /// Disconnects this instance.
        /// </summary>
        void Disconnect();
        /// <summary>
        /// Ensures the authenticated.
        /// </summary>
        void EnsureAuthenticated();
        /// <summary>
        /// Finds the server location.
        /// </summary>
        /// <param name="serverGuid">The server unique identifier.</param>
        /// <returns>String.</returns>
        String FindServerLocation(Guid serverGuid);
        /// <summary>
        /// Reacts to possible server update.
        /// </summary>
        /// <param name="serverLastChangeId">The server last change identifier.</param>
        void ReactToPossibleServerUpdate(Int32 serverLastChangeId);
        /// <summary>
        /// Gets the authenticated identity.
        /// </summary>
        /// <value>The authenticated identity.</value>
        ITeamFoundationIdentity AuthenticatedIdentity { get; }
        /// <summary>
        /// Gets the authorized identity.
        /// </summary>
        /// <value>The authorized identity.</value>
        ITeamFoundationIdentity AuthorizedIdentity { get; }
        /// <summary>
        /// Gets the cached instance identifier.
        /// </summary>
        /// <value>The cached instance identifier.</value>
        Guid CachedInstanceId { get; }
        /// <summary>
        /// Gets the catalog resource identifier.
        /// </summary>
        /// <value>The catalog resource identifier.</value>
        Guid CatalogResourceId { get; }
        /// <summary>
        /// Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        String ClientCacheDirectoryForInstance { get; }
        /// <summary>
        /// Gets the client cache directory for user.
        /// </summary>
        /// <value>The client cache directory for user.</value>
        String ClientCacheDirectoryForUser { get; }
        /// <summary>
        /// Gets the client volatile cache directory for instance.
        /// </summary>
        /// <value>The client volatile cache directory for instance.</value>
        String ClientVolatileCacheDirectoryForInstance { get; }
        /// <summary>
        /// Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        Boolean HasAuthenticated { get; }
        /// <summary>
        /// Gets the instance identifier.
        /// </summary>
        /// <value>The instance identifier.</value>
        Guid InstanceId { get; }
        /// <summary>
        /// Gets the server capabilities.
        /// </summary>
        /// <value>The server capabilities.</value>
        IServerCapabilities ServerCapabilities { get; }
    }
}