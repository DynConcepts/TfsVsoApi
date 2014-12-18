using System;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class WorkItemFieldWrapper.
    /// </summary>
    internal class WorkItemFieldWrapper : IWorkItemFieldDefinition
    {
        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return r_Instance.Name; } }

        /// <summary>
        ///     Gets a value indicating whether [read o inly].
        /// </summary>
        /// <value><c>true</c> if [read o inly]; otherwise, <c>false</c>.</value>
        public bool ReadOInly { get { return !r_Instance.IsEditable; } }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        public string ReferenceName { get { return r_Instance.ReferenceName; } }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get { return r_Instance.SystemType; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemFieldWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public WorkItemFieldWrapper(FieldDefinition instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly FieldDefinition r_Instance;
    }
}