using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class BatchReadParameterImpl.
    /// </summary>
    internal class BatchReadParameterImpl : IBatchReadParameter
    {
        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IBatchReadParameter.Id { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the project hint.
        /// </summary>
        /// <value>The project hint.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IBatchReadParameter.ProjectHint { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the revision.
        /// </summary>
        /// <value>The revision.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IBatchReadParameter.Revision { get { throw new ToBeImplementedException(); } }
    }
}