using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IServerInfo
    /// </summary>
    public interface IServerInfo
    {
        /// <summary>
        /// Determines whether the specified feature is supported.
        /// </summary>
        /// <param name="feature">The feature.</param>
        /// <returns>Boolean.</returns>
        Boolean IsSupported(String feature);
        /// <summary>
        /// Gets the features.
        /// </summary>
        /// <value>The features.</value>
        IEnumerable<String> Features { get; }
    }
}