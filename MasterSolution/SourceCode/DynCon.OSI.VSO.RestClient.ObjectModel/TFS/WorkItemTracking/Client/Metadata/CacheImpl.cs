using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata
{
    internal class CacheImpl : ICache
    {
        ISnapshot ICache.GetSnapshot() { throw new ToBeImplementedException(); }
    }
}