using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class WorkItemTypeCategoryWrapper.
    /// </summary>
    internal class WorkItemTypeCategoryWrapper : IWorkItemTypeCategory
    {
        /// <summary>
        ///     Gets the default type of the work item.
        /// </summary>
        /// <value>The default type of the work item.</value>
        public IWorkItemType DefaultWorkItemType { get { return WorkItemTypeWrapper.GetWrapper(r_Instance.DefaultWorkItemType); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return r_Instance.Name; } }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        public string ReferenceName { get { return r_Instance.ReferenceName; } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        /// <exception cref="System.NotSupportedException"></exception>
        public string Url { get { throw new NotSupportedException(); } }

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        public IReadOnlyList<IWorkItemType> WorkItemTypes { get { return r_WorkItemTypes.Value; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemTypeCategoryWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public WorkItemTypeCategoryWrapper(Category instance)
        {
            r_Instance = instance;
            r_WorkItemTypes = new Lazy<List<IWorkItemType>>(() => r_Instance.WorkItemTypes.Select(WorkItemTypeWrapper.GetWrapper).ToList());
        }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly Category r_Instance;

        /// <summary>
        ///     The _work item types
        /// </summary>
        private readonly Lazy<List<IWorkItemType>> r_WorkItemTypes;
    }
}