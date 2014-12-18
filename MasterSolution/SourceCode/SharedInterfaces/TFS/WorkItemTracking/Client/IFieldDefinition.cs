namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IFieldDefinition
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAllowedValuesCollection FilteredAllowedValues( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList filters);
    System.String Name  { get;   }
    System.String ReferenceName  { get;   }
    System.Int32 Id  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldUsages Usage  { get;   }
    System.Boolean IsIndexed  { get;   }
    System.Boolean IsCoreField  { get;   }
    System.Boolean IsEditable  { get;   }
    System.Boolean IsComputed  { get;   }
    System.Boolean IsUserNameField  { get;   }
    System.String HelpText  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldType FieldType  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IReportingAttributes ReportingAttributes  { get;   }
    System.Type SystemType  { get;   }
    System.Boolean IsQueryable  { get;   }
    System.Boolean CanSortBy  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore.IPsFieldDefinitionTypeEnum PsFieldType  { get;   }
    System.Boolean IsLongText  { get;   }
    System.Boolean SupportsTextQuery  { get;   }
    System.Boolean IsCloneable  { get;   }
    System.Boolean IsInternal  { get;   }
    System.Int32 PsReportingType  { get;   }
    System.Int32 PsReportingFormula  { get;   }
    System.Boolean IsReportable  { get;   }
    System.String ReportingName  { get;   }
    System.String ReportingReferenceName  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAllowedValuesCollection AllowedValues  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection ProhibitedValues  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore WorkItemStore  { get;   }
    System.Boolean IsUsedInWorkItemType  { get;   }
    System.Boolean IsUsedInGlobalWorkflow  { get;   }
  }
}
