using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IImportEventArgs
    /// </summary>
    public interface IImportEventArgs
    {
        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        Exception Exception { get; }
        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>The message.</value>
        String Message { get; }
        /// <summary>
        /// Gets the severity.
        /// </summary>
        /// <value>The severity.</value>
        IImportSeverity Severity { get; }
    }
}