using System.ComponentModel;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
{
    /// <summary>
    /// Interface IField
    /// </summary>
    public interface IField
    {
        // Summary:
        //     Gets a collection of values that are valid for this field.
        //
        // Returns:
        //     A collection of values that are valid for this field.
        /// <summary>
        /// Gets the allowed values.
        /// </summary>
        /// <value>The allowed values.</value>
         IAllowedValuesCollection AllowedValues { get; }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.WorkItemTracking.Client.FieldDefinition
        //     that defines this field.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.WorkItemTracking.Client.FieldDefinition that
        //     defines this field.
         /// <summary>
         /// Gets the field definition.
         /// </summary>
         /// <value>The field definition.</value>
         IFieldDefinition FieldDefinition { get; }
        //
        // Summary:
        //     Gets a flag that indicates whether a list of allowed values is available
        //     for this field.
        //
        // Returns:
        //     True if a list of allowed values exists; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance has allowed values list.
        /// </summary>
        /// <value><c>true</c> if this instance has allowed values list; otherwise, <c>false</c>.</value>
        bool HasAllowedValuesList { get; }
        //
        // Summary:
        //     Gets a flag that indicates whether the value of this field must match a pattern.
        //
        // Returns:
        //     True if the value of this field must match a pattern; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance has pattern match.
        /// </summary>
        /// <value><c>true</c> if this instance has pattern match; otherwise, <c>false</c>.</value>
        bool HasPatternMatch { get; }
        //
        // Summary:
        //     Gets the ID of this field.
        //
        // Returns:
        //     The ID of this field.
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is changed by user.
        /// </summary>
        /// <value><c>true</c> if this instance is changed by user; otherwise, <c>false</c>.</value>
        bool IsChangedByUser { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is changed in revision.
        /// </summary>
        /// <value><c>true</c> if this instance is changed in revision; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        bool IsChangedInRevision { get; }
        //
        // Summary:
        //     Gets a flag that indicates whether the value of this field is computed from
        //     the values of other fields.
        //
        // Returns:
        //     True if the value of this field is computed; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance is computed.
        /// </summary>
        /// <value><c>true</c> if this instance is computed; otherwise, <c>false</c>.</value>
        bool IsComputed { get; }
        //
        // Summary:
        //     Gets a flag that indicates whether the value of this field has unsaved changes.
        //
        // Returns:
        //     True if the field has unsaved changes; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance is dirty.
        /// </summary>
        /// <value><c>true</c> if this instance is dirty; otherwise, <c>false</c>.</value>
        bool IsDirty { get; }
        //
        // Summary:
        //     Gets a flag that indicates whether the value of this field can be edited
        //     in the current state of the work item.
        //
        // Returns:
        //     True if the value of the field can be edited; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance is editable.
        /// </summary>
        /// <value><c>true</c> if this instance is editable; otherwise, <c>false</c>.</value>
        bool IsEditable { get; }
        //
        // Summary:
        //     Gets a flag that indicates whether this field is restricted to a collection
        //     of allowed values.
        //
        // Returns:
        //     True if the field is restricted to a collection of allowed values; otherwise,
        //     false.
        /// <summary>
        /// Gets a value indicating whether this instance is limited to allowed values.
        /// </summary>
        /// <value><c>true</c> if this instance is limited to allowed values; otherwise, <c>false</c>.</value>
        bool IsLimitedToAllowedValues { get; }
        //
        // Summary:
        //     Gets a flag that indicates whether this field requires a value.
        //
        // Returns:
        //     True if the field requires a value; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance is required.
        /// </summary>
        /// <value><c>true</c> if this instance is required; otherwise, <c>false</c>.</value>
        bool IsRequired { get; }
        //
        // Summary:
        //     Gets a flag that indicates whether the value of the field is valid based
        //     on rules.
        //
        // Returns:
        //     True if the value is valid; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        bool IsValid { get; }
        //
        // Summary:
        //     Gets the name of this field.
        //
        // Returns:
        //     The name of this field.
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
        //
        // Summary:
        //     Gets the value of this field as it existed when the work item was saved most
        //     recently.
        //
        // Returns:
        //     The value of this field as it existed when the work item was saved most recently.
        /// <summary>
        /// Gets the original value.
        /// </summary>
        /// <value>The original value.</value>
        object OriginalValue { get; }
        //
        // Summary:
        //     Gets the list of values that are not allowed for this field.
        //
        // Returns:
        //     A list of values that are not allowed for this field.
        /// <summary>
        /// Gets the prohibited values.
        /// </summary>
        /// <value>The prohibited values.</value>
        IValuesCollection ProhibitedValues { get; }
        //
        // Summary:
        //     Gets the reference name of this field.
        //
        // Returns:
        //     The reference name of this field.
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        string ReferenceName { get; }
        //
        // Summary:
        //     Gets a description of the current state of this field.
        //
        // Returns:
        //     A description of the current state of this field.
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        FieldStatus Status { get; }
        //
        // Summary:
        //     Gets or sets the current value of this field.
        //
        // Returns:
        //     The current value of this field.
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        object Value { get; set; }
        /// <summary>
        /// Gets the value with server default.
        /// </summary>
        /// <value>The value with server default.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        object ValueWithServerDefault { get; }
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem that contains
        //     this field.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem that contains
        //     this field.
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem WorkItem { get; }
    }

    /// <summary>
    /// Enum FieldStatus
    /// </summary>
    public enum FieldStatus
    {
        /// <summary>
        /// The valid
        /// </summary>
        Valid
    }

    /// <summary>
    /// Interface IValuesCollection
    /// </summary>
    public interface IValuesCollection
    {
    }

   
    /// <summary>
    /// Interface IAllowedValuesCollection
    /// </summary>
    public interface IAllowedValuesCollection
    {
    }
}