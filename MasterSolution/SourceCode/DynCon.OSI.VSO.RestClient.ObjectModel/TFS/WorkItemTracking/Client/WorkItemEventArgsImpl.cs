using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemEventArgsImpl.
    /// </summary>
    internal class WorkItemEventArgsImpl : IWorkItemEventArgs
    {
        /// <summary>
        ///     Gets the field.
        /// </summary>
        /// <value>The field.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IField IWorkItemEventArgs.Field { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the object.
        /// </summary>
        /// <value>The object.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object IWorkItemEventArgs.Object { get { throw new ToBeImplementedException(); } }
    }
}