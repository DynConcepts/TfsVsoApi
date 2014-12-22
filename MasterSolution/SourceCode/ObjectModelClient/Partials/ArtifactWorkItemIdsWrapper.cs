using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

// ReSharper disable once CheckNamespace

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal partial class ArtifactWorkItemIdsWrapper : IArtifactWorkItemIds
    {
        internal static IIResultCollection<IArtifactWorkItemIds>
            GetWrapper(IResultCollection<ArtifactWorkItemIds>
                src)
        {
            var retVal = new IResultCollectionWrapper<IArtifactWorkItemIds>(null);
            foreach (ArtifactWorkItemIds item in src)
            {
                IArtifactWorkItemIds wrapped = GetWrapper(item);
                retVal.Add(wrapped);
            }
            return retVal;
        }
    }
}