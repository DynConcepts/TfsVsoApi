using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class ImportEventArgsImpl.
    /// </summary>
    internal class ImportEventArgsImpl : IImportEventArgs
    {
        /// <summary>
        ///     Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Exception IImportEventArgs.Exception { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the message.
        /// </summary>
        /// <value>The message.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IImportEventArgs.Message { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the severity.
        /// </summary>
        /// <value>The severity.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IImportSeverity IImportEventArgs.Severity { get { throw new ToBeImplementedException(); } }
    }
}