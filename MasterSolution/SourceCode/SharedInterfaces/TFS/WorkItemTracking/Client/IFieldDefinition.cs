using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IFieldDefinition
    {
        IAllowedValuesCollection FilteredAllowedValues(IFieldFilterList filters);
        IAllowedValuesCollection AllowedValues { get; }
        Boolean CanSortBy { get; }
        IFieldType FieldType { get; }
        String HelpText { get; }
        Int32 Id { get; }
        Boolean IsCloneable { get; }
        Boolean IsComputed { get; }
        Boolean IsCoreField { get; }
        Boolean IsEditable { get; }
        Boolean IsIndexed { get; }
        Boolean IsInternal { get; }
        Boolean IsLongText { get; }
        Boolean IsQueryable { get; }
        Boolean IsReportable { get; }
        Boolean IsUsedInGlobalWorkflow { get; }
        Boolean IsUsedInWorkItemType { get; }
        Boolean IsUserNameField { get; }
        String Name { get; }
        IValuesCollection ProhibitedValues { get; }
        IPsFieldDefinitionTypeEnum PsFieldType { get; }
        Int32 PsReportingFormula { get; }
        Int32 PsReportingType { get; }
        String ReferenceName { get; }
        IReportingAttributes ReportingAttributes { get; }
        String ReportingName { get; }
        String ReportingReferenceName { get; }
        Boolean SupportsTextQuery { get; }
        Type SystemType { get; }
        IFieldUsages Usage { get; }
        IWorkItemStore WorkItemStore { get; }
    }
}