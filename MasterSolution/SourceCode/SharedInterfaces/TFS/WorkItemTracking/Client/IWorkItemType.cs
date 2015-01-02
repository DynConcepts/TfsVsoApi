using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemType
    /// </summary>
    public interface IWorkItemType
    {
        /// <summary>
        /// Exports the specified include global lists flag.
        /// </summary>
        /// <param name="includeGlobalListsFlag">The include global lists flag.</param>
        /// <returns>XmlDocument.</returns>
        XmlDocument Export(Boolean includeGlobalListsFlag);
        /// <summary>
        /// Gets the state of the next.
        /// </summary>
        /// <param name="currentState">State of the current.</param>
        /// <param name="action">The action.</param>
        /// <returns>String.</returns>
        String GetNextState(String currentState, String action);
        /// <summary>
        /// News the work item.
        /// </summary>
        /// <returns>IWorkItem.</returns>
        IWorkItem NewWorkItem();
        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        String Description { get; }
        /// <summary>
        /// Gets the display form.
        /// </summary>
        /// <value>The display form.</value>
        String DisplayForm { get; }
        /// <summary>
        /// Gets the field definitions.
        /// </summary>
        /// <value>The field definitions.</value>
        IFieldDefinitionCollection FieldDefinitions { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the project.
        /// </summary>
        /// <value>The project.</value>
        IProject Project { get; }
        /// <summary>
        /// Gets the store.
        /// </summary>
        /// <value>The store.</value>
        IWorkItemStore Store { get; }
    }
}