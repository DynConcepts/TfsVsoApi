using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class MetadataEventArgsImpl.
    /// </summary>
    internal class MetadataEventArgsImpl : IMetadataEventArgs
    {
        /// <summary>
        ///     Gets the metadata change flags.
        /// </summary>
        /// <value>The metadata change flags.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IMetadataChangeTypes IMetadataEventArgs.MetadataChangeFlags { get { throw new ToBeImplementedException(); } }
    }
}