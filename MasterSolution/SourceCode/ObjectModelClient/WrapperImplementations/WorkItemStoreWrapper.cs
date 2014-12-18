using System;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class WorkItemStoreWrapper.
    /// </summary>
    internal class WorkItemStoreWrapper
    {
        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="store">The store.</param>
        /// <returns>IWorkItemStoreOM.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static IWorkItemStoreOM GetWrapper(WorkItemStore store) { throw new NotImplementedException(); }
    }
}