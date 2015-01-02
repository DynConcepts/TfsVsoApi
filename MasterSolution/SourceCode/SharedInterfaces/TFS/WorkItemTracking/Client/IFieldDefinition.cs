using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IFieldDefinition
    /// </summary>
    public interface IFieldDefinition
    {
        /// <summary>
        /// Filtereds the allowed values.
        /// </summary>
        /// <param name="filters">The filters.</param>
        /// <returns>IAllowedValuesCollection.</returns>
        IAllowedValuesCollection FilteredAllowedValues(IFieldFilterList filters);
        /// <summary>
        /// Gets the allowed values.
        /// </summary>
        /// <value>The allowed values.</value>
        IAllowedValuesCollection AllowedValues { get; }
        /// <summary>
        /// Gets the can sort by.
        /// </summary>
        /// <value>The can sort by.</value>
        Boolean CanSortBy { get; }
        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        IFieldType FieldType { get; }
        /// <summary>
        /// Gets the help text.
        /// </summary>
        /// <value>The help text.</value>
        String HelpText { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 Id { get; }
        /// <summary>
        /// Gets the is cloneable.
        /// </summary>
        /// <value>The is cloneable.</value>
        Boolean IsCloneable { get; }
        /// <summary>
        /// Gets the is computed.
        /// </summary>
        /// <value>The is computed.</value>
        Boolean IsComputed { get; }
        /// <summary>
        /// Gets the is core field.
        /// </summary>
        /// <value>The is core field.</value>
        Boolean IsCoreField { get; }
        /// <summary>
        /// Gets the is editable.
        /// </summary>
        /// <value>The is editable.</value>
        Boolean IsEditable { get; }
        /// <summary>
        /// Gets the is indexed.
        /// </summary>
        /// <value>The is indexed.</value>
        Boolean IsIndexed { get; }
        /// <summary>
        /// Gets the is internal.
        /// </summary>
        /// <value>The is internal.</value>
        Boolean IsInternal { get; }
        /// <summary>
        /// Gets the is long text.
        /// </summary>
        /// <value>The is long text.</value>
        Boolean IsLongText { get; }
        /// <summary>
        /// Gets the is queryable.
        /// </summary>
        /// <value>The is queryable.</value>
        Boolean IsQueryable { get; }
        /// <summary>
        /// Gets the is reportable.
        /// </summary>
        /// <value>The is reportable.</value>
        Boolean IsReportable { get; }
        /// <summary>
        /// Gets the is used in global workflow.
        /// </summary>
        /// <value>The is used in global workflow.</value>
        Boolean IsUsedInGlobalWorkflow { get; }
        /// <summary>
        /// Gets the type of the is used in work item.
        /// </summary>
        /// <value>The type of the is used in work item.</value>
        Boolean IsUsedInWorkItemType { get; }
        /// <summary>
        /// Gets the is user name field.
        /// </summary>
        /// <value>The is user name field.</value>
        Boolean IsUserNameField { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the prohibited values.
        /// </summary>
        /// <value>The prohibited values.</value>
        IValuesCollection ProhibitedValues { get; }
        /// <summary>
        /// Gets the type of the ps field.
        /// </summary>
        /// <value>The type of the ps field.</value>
        IPsFieldDefinitionTypeEnum PsFieldType { get; }
        /// <summary>
        /// Gets the ps reporting formula.
        /// </summary>
        /// <value>The ps reporting formula.</value>
        Int32 PsReportingFormula { get; }
        /// <summary>
        /// Gets the type of the ps reporting.
        /// </summary>
        /// <value>The type of the ps reporting.</value>
        Int32 PsReportingType { get; }
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        String ReferenceName { get; }
        /// <summary>
        /// Gets the reporting attributes.
        /// </summary>
        /// <value>The reporting attributes.</value>
        IReportingAttributes ReportingAttributes { get; }
        /// <summary>
        /// Gets the name of the reporting.
        /// </summary>
        /// <value>The name of the reporting.</value>
        String ReportingName { get; }
        /// <summary>
        /// Gets the name of the reporting reference.
        /// </summary>
        /// <value>The name of the reporting reference.</value>
        String ReportingReferenceName { get; }
        /// <summary>
        /// Gets the supports text query.
        /// </summary>
        /// <value>The supports text query.</value>
        Boolean SupportsTextQuery { get; }
        /// <summary>
        /// Gets the type of the system.
        /// </summary>
        /// <value>The type of the system.</value>
        Type SystemType { get; }
        /// <summary>
        /// Gets the usage.
        /// </summary>
        /// <value>The usage.</value>
        IFieldUsages Usage { get; }
        /// <summary>
        /// Gets the work item store.
        /// </summary>
        /// <value>The work item store.</value>
        IWorkItemStore WorkItemStore { get; }
    }
}