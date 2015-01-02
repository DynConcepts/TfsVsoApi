using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IField
    /// </summary>
    public interface IField
    {
        /// <summary>
        /// Gets the allowed values.
        /// </summary>
        /// <value>The allowed values.</value>
        IAllowedValuesCollection AllowedValues { get; }
        /// <summary>
        /// Gets the field definition.
        /// </summary>
        /// <value>The field definition.</value>
        IFieldDefinition FieldDefinition { get; }
        /// <summary>
        /// Gets the has allowed values list.
        /// </summary>
        /// <value>The has allowed values list.</value>
        Boolean HasAllowedValuesList { get; }
        /// <summary>
        /// Gets the has pattern match.
        /// </summary>
        /// <value>The has pattern match.</value>
        Boolean HasPatternMatch { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 Id { get; }
        /// <summary>
        /// Gets the is changed by user.
        /// </summary>
        /// <value>The is changed by user.</value>
        Boolean IsChangedByUser { get; }
        /// <summary>
        /// Gets the is changed in revision.
        /// </summary>
        /// <value>The is changed in revision.</value>
        Boolean IsChangedInRevision { get; }
        /// <summary>
        /// Gets the is computed.
        /// </summary>
        /// <value>The is computed.</value>
        Boolean IsComputed { get; }
        /// <summary>
        /// Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        Boolean IsDirty { get; }
        /// <summary>
        /// Gets the is editable.
        /// </summary>
        /// <value>The is editable.</value>
        Boolean IsEditable { get; }
        /// <summary>
        /// Gets the is limited to allowed values.
        /// </summary>
        /// <value>The is limited to allowed values.</value>
        Boolean IsLimitedToAllowedValues { get; }
        /// <summary>
        /// Gets the is required.
        /// </summary>
        /// <value>The is required.</value>
        Boolean IsRequired { get; }
        /// <summary>
        /// Gets the is valid.
        /// </summary>
        /// <value>The is valid.</value>
        Boolean IsValid { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the original value.
        /// </summary>
        /// <value>The original value.</value>
        Object OriginalValue { get; }
        /// <summary>
        /// Gets the prohibited values.
        /// </summary>
        /// <value>The prohibited values.</value>
        IValuesCollection ProhibitedValues { get; }
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        String ReferenceName { get; }
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        IFieldStatus Status { get; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        Object Value { get; set; }
        /// <summary>
        /// Gets the value with server default.
        /// </summary>
        /// <value>The value with server default.</value>
        Object ValueWithServerDefault { get; }
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem WorkItem { get; }
    }
}