using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemOperationErrorImpl.
    /// </summary>
    internal class WorkItemOperationErrorImpl : IWorkItemOperationError
    {
        /// <summary>
        ///     Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Exception IWorkItemOperationError.Exception { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemOperationError.Id { get { throw new ToBeImplementedException(); } }
    }
}