using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class ServerInfoImpl.
    /// </summary>
    internal class ServerInfoImpl : IServerInfo
    {
        /// <summary>
        ///     Gets the features.
        /// </summary>
        /// <value>The features.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<String> IServerInfo.Features { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Determines whether the specified feature is supported.
        /// </summary>
        /// <param name="feature">The feature.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IServerInfo.IsSupported(String feature) { throw new ToBeImplementedException(); }
    }
}