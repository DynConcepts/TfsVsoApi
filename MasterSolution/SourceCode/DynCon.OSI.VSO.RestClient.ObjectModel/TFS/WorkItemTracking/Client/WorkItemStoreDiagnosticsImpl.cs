using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemStoreDiagnosticsImpl.
    /// </summary>
    internal class WorkItemStoreDiagnosticsImpl : IWorkItemStoreDiagnostics
    {
        /// <summary>
        ///     Gets the round trip count.
        /// </summary>
        /// <value>The round trip count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemStoreDiagnostics.RoundTripCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the round trip time.
        /// </summary>
        /// <value>The round trip time.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int64 IWorkItemStoreDiagnostics.RoundTripTime { get { throw new ToBeImplementedException(); } }
    }
}