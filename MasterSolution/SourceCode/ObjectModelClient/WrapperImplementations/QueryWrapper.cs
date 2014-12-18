using System;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class QueryWrapper.
    /// </summary>
    internal class QueryWrapper
    {
        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>IQueryOM.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static IQueryOM GetWrapper(Query query) { throw new NotImplementedException(); }
    }
}