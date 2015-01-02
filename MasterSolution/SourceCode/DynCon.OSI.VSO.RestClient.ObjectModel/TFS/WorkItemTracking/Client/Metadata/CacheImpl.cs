using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>
    ///     Class CacheImpl.
    /// </summary>
    internal class CacheImpl : ICache
    {
        /// <summary>
        ///     Gets the snapshot.
        /// </summary>
        /// <returns>ISnapshot.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ISnapshot ICache.GetSnapshot() { throw new ToBeImplementedException(); }
    }
}