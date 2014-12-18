using System;
using System.ComponentModel;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
{
    /// <summary>
    /// Represents a TFS/VSO WorkItem Field Definition
    /// </summary>
    public interface IFieldDefinition
    {
         /// <summary>
        /// Gets a value indicating whether [read o inly].
        /// </summary>
        /// <value><c>true</c> if [read o inly]; otherwise, <c>false</c>.</value>
        bool ReadOInly { get; }

  
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        Type Type { get; }

        // Summary:
        //     Gets the collection of valid values for a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition.
        //
        // Returns:
        //     The collection of valid values for a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition.
        /// <summary>
        /// Gets the allowed values.
        /// </summary>
        /// <value>The allowed values.</value>
         IAllowedValuesCollection AllowedValues { get; }
        //
        // Summary:
        //     Gets the flag that describes whether Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItems
        //     can be sorted by Microsoft.TeamFoundation.WorkItemTracking.Client.Fields
        //     that use this field definition.
        //
        // Returns:
        //     True if Microsoft.TeamFoundation.WorkItemTracking.Client.Fields that use
        //     this field definition can be used to sort Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItems;
        //     otherwise, false.
         /// <summary>
         /// Gets a value indicating whether this instance can sort by.
         /// </summary>
         /// <value><c>true</c> if this instance can sort by; otherwise, <c>false</c>.</value>
         bool CanSortBy { get; }
        //
        // Summary:
        //     Gets the data type that is stored by a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition.
        //
        // Returns:
        //     The data type that is stored by a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition.
         /// <summary>
         /// Gets the type of the field.
         /// </summary>
         /// <value>The type of the field.</value>
         IFieldType FieldType { get; }
        //
        // Summary:
        //     Gets the text that describes this field definition.
        //
        // Returns:
        //     The text that describes this field definition.
         /// <summary>
         /// Gets the help text.
         /// </summary>
         /// <value>The help text.</value>
         string HelpText { get; }
        //
        // Summary:
        //     Gets the ID of this field definition.
        //
        // Returns:
        //     The ID of this field definition.
         /// <summary>
         /// Gets the identifier.
         /// </summary>
         /// <value>The identifier.</value>
         int Id { get; }
         /// <summary>
         /// Gets a value indicating whether this instance is cloneable.
         /// </summary>
         /// <value><c>true</c> if this instance is cloneable; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         bool IsCloneable { get; }
        //
        // Summary:
        //     Gets a flag that describes whether the value of the Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition is computed.
        //
        // Returns:
        //     True if the value of the Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition is computed; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance is computed.
        /// </summary>
        /// <value><c>true</c> if this instance is computed; otherwise, <c>false</c>.</value>
         bool IsComputed { get; }
        //
        // Summary:
        //     Returns whether a field is indexed.
         /// <summary>
         /// Gets a value indicating whether this instance is core field.
         /// </summary>
         /// <value><c>true</c> if this instance is core field; otherwise, <c>false</c>.</value>
         bool IsCoreField { get; }
        //
        // Summary:
        //     Gets a flag that describes whether a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition is editable.
        //
        // Returns:
        //     True if a Microsoft.TeamFoundation.WorkItemTracking.Client.Field that uses
        //     this field definition is editable; otherwise, false.
         /// <summary>
         /// Gets a value indicating whether this instance is editable.
         /// </summary>
         /// <value><c>true</c> if this instance is editable; otherwise, <c>false</c>.</value>
         bool IsEditable { get; }
        //
        // Summary:
        //     Gets a flag that describes whether a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition is indexed on the server.
        //
        // Returns:
        //     True if a Microsoft.TeamFoundation.WorkItemTracking.Client.Field that uses
        //     this field definition is indexed; otherwise, false.
         /// <summary>
         /// Gets a value indicating whether this instance is indexed.
         /// </summary>
         /// <value><c>true</c> if this instance is indexed; otherwise, <c>false</c>.</value>
         bool IsIndexed { get; }
         /// <summary>
         /// Gets a value indicating whether this instance is internal.
         /// </summary>
         /// <value><c>true</c> if this instance is internal; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         bool IsInternal { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is long text.
        /// </summary>
        /// <value><c>true</c> if this instance is long text; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         bool IsLongText { get; }
        //
        // Summary:
        //     Gets a flag that describes whether work items can be queried by a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition.
        //
        // Returns:
        //     True if a Microsoft.TeamFoundation.WorkItemTracking.Client.Field that uses
        //     this field definition can be queried; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance is queryable.
        /// </summary>
        /// <value><c>true</c> if this instance is queryable; otherwise, <c>false</c>.</value>
         bool IsQueryable { get; }
         /// <summary>
         /// Gets a value indicating whether this instance is reportable.
         /// </summary>
         /// <value><c>true</c> if this instance is reportable; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         bool IsReportable { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is used in global workflow.
        /// </summary>
        /// <value><c>true</c> if this instance is used in global workflow; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         bool IsUsedInGlobalWorkflow { get;}
        /// <summary>
        /// Gets a value indicating whether this instance is used in work item type.
        /// </summary>
        /// <value><c>true</c> if this instance is used in work item type; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         bool IsUsedInWorkItemType { get;}
        /// <summary>
        /// Gets a value indicating whether this instance is user name field.
        /// </summary>
        /// <value><c>true</c> if this instance is user name field; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         bool IsUserNameField { get; }
        //
        // Summary:
        //     Gets the friendly display name of this field definition.
        //
        // Returns:
        //     The friendly display name of this field definition.
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
         string Name { get; }
         /// <summary>
         /// Gets the prohibited values.
         /// </summary>
         /// <value>The prohibited values.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         IValuesCollection ProhibitedValues { get; }
        /// <summary>
        /// Gets the type of the ps field.
        /// </summary>
        /// <value>The type of the ps field.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         PsFieldDefinitionTypeEnum PsFieldType { get; }
        /// <summary>
        /// Gets the ps reporting formula.
        /// </summary>
        /// <value>The ps reporting formula.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         int PsReportingFormula { get; }
        /// <summary>
        /// Gets the type of the ps reporting.
        /// </summary>
        /// <value>The type of the ps reporting.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         int PsReportingType { get; }
        //
        // Summary:
        //     Gets the reference name of this field definition.
        //
        // Returns:
        //     The reference name of this field definition.
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
         string ReferenceName { get; }
        //
        // Summary:
        //     Gets the reporting attributes of this field definition.
        //
        // Returns:
        //     The reporting attributes of this field definition.
         /// <summary>
         /// Gets the reporting attributes.
         /// </summary>
         /// <value>The reporting attributes.</value>
         IReportingAttributes ReportingAttributes { get; }
         /// <summary>
         /// Gets the name of the reporting.
         /// </summary>
         /// <value>The name of the reporting.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         string ReportingName { get; }
        /// <summary>
        /// Gets the name of the reporting reference.
        /// </summary>
        /// <value>The name of the reporting reference.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         string ReportingReferenceName { get; }
        /// <summary>
        /// Gets a value indicating whether [supports text query].
        /// </summary>
        /// <value><c>true</c> if [supports text query]; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         bool SupportsTextQuery { get; }
        //
        // Summary:
        //     Gets the underlying System.Type of this field definition.
        //
        // Returns:
        //     The underlying System.Type of this field definition.
        /// <summary>
        /// Gets the type of the system.
        /// </summary>
        /// <value>The type of the system.</value>
         Type SystemType { get; }
        //
        // Summary:
        //     Gets the intended usage of this field definition.
        //
        // Returns:
        //     The intended usage of this field definition.
         /// <summary>
         /// Gets the usage.
         /// </summary>
         /// <value>The usage.</value>
         IFieldUsages Usage { get; }
         /// <summary>
         /// Gets the work item store.
         /// </summary>
         /// <value>The work item store.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
         IWorkItemStore WorkItemStore { get; }

        // Summary:
        //     Gets the collection of allowed values for a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition, which is filtered by the specified list
        //     of filters.
        //
        // Parameters:
        //   filters:
        //     A list of filters to apply to the list.
        //
        // Returns:
        //     The collection of allowed values for a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that uses this field definition, which is filtered by the specified list
        //     of filters.
        /// <summary>
        /// Filtereds the allowed values.
        /// </summary>
        /// <param name="filters">The filters.</param>
        /// <returns>AllowedValuesCollection.</returns>
         IAllowedValuesCollection FilteredAllowedValues(IFieldFilterList filters);

    }

    /// <summary>
    /// Interface IFieldType
    /// </summary>
    public interface IFieldType
    {
    }

    /// <summary>
    /// Enum PsFieldDefinitionTypeEnum
    /// </summary>
    public enum PsFieldDefinitionTypeEnum
    {
    }

    /// <summary>
    /// Interface IFieldFilterList
    /// </summary>
    public interface IFieldFilterList
    {
    }

    /// <summary>
    /// Interface IFieldUsages
    /// </summary>
    public interface IFieldUsages
    {
    }

    /// <summary>
    /// Interface IReportingAttributes
    /// </summary>
    public interface IReportingAttributes
    {
    }
}