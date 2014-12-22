using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemTypeImpl.
    /// </summary>
    internal class WorkItemTypeImpl : JsonWorkItemType, IWorkItemType
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>WorkItemTypeImpl.</returns>
        public static new WorkItemTypeImpl FromToken(JToken token)
        {
            var instance = new WorkItemTypeImpl(token);
            return instance;
        }

        /// <summary>
        ///     Gets the description.
        /// </summary>
        /// <value>The description.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemType.Description { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the display form.
        /// </summary>
        /// <value>The display form.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemType.DisplayForm { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Exports the specified include global lists flag.
        /// </summary>
        /// <param name="includeGlobalListsFlag">The include global lists flag.</param>
        /// <returns>XmlDocument.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        XmlDocument IWorkItemType.Export(Boolean includeGlobalListsFlag) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the field definitions.
        /// </summary>
        /// <value>The field definitions.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldDefinitionCollection IWorkItemType.FieldDefinitions { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the state of the next.
        /// </summary>
        /// <param name="currentState">State of the current.</param>
        /// <param name="action">The action.</param>
        /// <returns>String.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemType.GetNextState(String currentState, String action) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemType.Name { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     News the work item.
        /// </summary>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IWorkItemType.NewWorkItem() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the project.
        /// </summary>
        /// <value>The project.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IProject IWorkItemType.Project { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the store.
        /// </summary>
        /// <value>The store.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemStore IWorkItemType.Store { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonWorkItemType" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        private WorkItemTypeImpl(JToken json) : base(json) { }
    }
}