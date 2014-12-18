using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class CategoryImpl.
    /// </summary>
    internal class CategoryImpl : JsonWorkItemTypeCategory,ICategory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public CategoryImpl(JToken json) : base(json) {
        }

        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean ICategory.Contains(IWorkItemType value) { throw new ToBeImplementedException(); }
        /// <summary>
        /// Gets the default type of the work item.
        /// </summary>
        /// <value>The default type of the work item.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemType ICategory.DefaultWorkItemType { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        String ICategory.Name { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        String ICategory.ReferenceName { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IEnumerable<IWorkItemType> ICategory.WorkItemTypes { get { throw new ToBeImplementedException(); } }
    }
}