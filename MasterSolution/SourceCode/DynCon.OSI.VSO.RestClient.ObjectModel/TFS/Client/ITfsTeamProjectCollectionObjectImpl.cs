using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class ITfsTeamProjectCollectionObjectImpl.
    /// </summary>
    internal class ITfsTeamProjectCollectionObjectImpl : IITfsTeamProjectCollectionObject
    {
        /// <summary>
        ///     Initializes the specified project collection.
        /// </summary>
        /// <param name="projectCollection">The project collection.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsTeamProjectCollectionObject.Initialize(ITfsTeamProjectCollection projectCollection) { throw new ToBeImplementedException(); }
    }
}