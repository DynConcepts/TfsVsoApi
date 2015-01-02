using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemStoreDiagnostics
    /// </summary>
    public interface IWorkItemStoreDiagnostics
    {
        /// <summary>
        /// Gets the round trip count.
        /// </summary>
        /// <value>The round trip count.</value>
        Int32 RoundTripCount { get; }
        /// <summary>
        /// Gets the round trip time.
        /// </summary>
        /// <value>The round trip time.</value>
        Int64 RoundTripTime { get; }
    }
}