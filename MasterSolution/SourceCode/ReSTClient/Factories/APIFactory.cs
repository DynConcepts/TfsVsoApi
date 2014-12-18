using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;

namespace DynCon.OSI.VSO.ReSTClient.Factories
{
    /// <summary>
    ///     Class APIFactory.
    /// </summary>
    public static class APIFactory
    {
        /// <summary>
        ///     Gets the work item API.
        /// </summary>
        /// <value>The work item API.</value>
        public static IWorkItemAPI WorkItemAPI { get { return new WorkItemAPI(); } }
    }
}