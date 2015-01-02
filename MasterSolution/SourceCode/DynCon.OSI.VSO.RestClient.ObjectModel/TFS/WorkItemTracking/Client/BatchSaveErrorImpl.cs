using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class BatchSaveErrorImpl.
    /// </summary>
    internal class BatchSaveErrorImpl : IBatchSaveError
    {
        /// <summary>
        ///     Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        Exception IBatchSaveError.Exception { get { return r_Exception; } }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem IBatchSaveError.WorkItem { get { return r_Workitem; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BatchSaveErrorImpl" /> class.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="workitem">The workitem.</param>
        internal BatchSaveErrorImpl(Exception exception, IWorkItem workitem)
        {
            r_Exception = exception;
            r_Workitem = workitem;
        }

        /// <summary>
        ///     The r_ exception
        /// </summary>
        private readonly Exception r_Exception;

        /// <summary>
        ///     The r_ workitem
        /// </summary>
        private readonly IWorkItem r_Workitem;
    }
}