using DynCon.OSI.Core;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class WorkItemTypeWrapper.
    /// </summary>
    internal class WorkItemTypeWrapper : MappedObjectBase<IWorkItemType, WorkItemType>, IWorkItemType
    {
        public static void SetMapper() { Mapper = new ObjectMapper<IWorkItemType, WorkItemType>(src => ((WorkItemTypeWrapper) src).r_Instance, src => new WorkItemTypeWrapper(src)); }

        /// <summary>
        ///     Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return r_Instance.Description; } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return r_Instance.Name; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemTypeWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        private WorkItemTypeWrapper(WorkItemType instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly WorkItemType r_Instance;
    }
}