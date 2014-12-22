using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IField
    {
        IAllowedValuesCollection AllowedValues { get; }
        IFieldDefinition FieldDefinition { get; }
        Boolean HasAllowedValuesList { get; }
        Boolean HasPatternMatch { get; }
        Int32 Id { get; }
        Boolean IsChangedByUser { get; }
        Boolean IsChangedInRevision { get; }
        Boolean IsComputed { get; }
        Boolean IsDirty { get; }
        Boolean IsEditable { get; }
        Boolean IsLimitedToAllowedValues { get; }
        Boolean IsRequired { get; }
        Boolean IsValid { get; }
        String Name { get; }
        Object OriginalValue { get; }
        IValuesCollection ProhibitedValues { get; }
        String ReferenceName { get; }
        IFieldStatus Status { get; }
        Object Value { get; set; }
        Object ValueWithServerDefault { get; }
        IWorkItem WorkItem { get; }
    }
}