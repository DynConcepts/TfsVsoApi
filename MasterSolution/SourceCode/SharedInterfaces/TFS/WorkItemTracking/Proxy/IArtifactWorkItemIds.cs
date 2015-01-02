using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IArtifactWorkItemIds
    /// </summary>
    public interface IArtifactWorkItemIds : IITfsXmlSerializable
    {
        /// <summary>
        /// Gets the work item ids.
        /// </summary>
        /// <returns>Int32[].</returns>
        Int32[] GetWorkItemIds();
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        String Uri { get; }
        /// <summary>
        /// Gets or sets the URI list offset.
        /// </summary>
        /// <value>The URI list offset.</value>
        Int32 UriListOffset { get; set; }
    }
}