using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class MetadataEventArgsImpl : IMetadataEventArgs
    {
        IMetadataChangeTypes IMetadataEventArgs.MetadataChangeFlags { get { throw new ToBeImplementedException(); } }
    }
}