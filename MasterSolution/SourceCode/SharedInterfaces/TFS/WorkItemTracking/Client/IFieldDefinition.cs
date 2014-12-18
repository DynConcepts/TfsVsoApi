using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IFieldDefinition
  {
    IAllowedValuesCollection FilteredAllowedValues( IFieldFilterList filters);
    String Name  { get;   }
    String ReferenceName  { get;   }
    Int32 Id  { get;   }
    IFieldUsages Usage  { get;   }
    Boolean IsIndexed  { get;   }
    Boolean IsCoreField  { get;   }
    Boolean IsEditable  { get;   }
    Boolean IsComputed  { get;   }
    Boolean IsUserNameField  { get;   }
    String HelpText  { get;   }
    IFieldType FieldType  { get;   }
    IReportingAttributes ReportingAttributes  { get;   }
    Type SystemType  { get;   }
    Boolean IsQueryable  { get;   }
    Boolean CanSortBy  { get;   }
    IPsFieldDefinitionTypeEnum PsFieldType  { get;   }
    Boolean IsLongText  { get;   }
    Boolean SupportsTextQuery  { get;   }
    Boolean IsCloneable  { get;   }
    Boolean IsInternal  { get;   }
    Int32 PsReportingType  { get;   }
    Int32 PsReportingFormula  { get;   }
    Boolean IsReportable  { get;   }
    String ReportingName  { get;   }
    String ReportingReferenceName  { get;   }
    IAllowedValuesCollection AllowedValues  { get;   }
    IValuesCollection ProhibitedValues  { get;   }
    IWorkItemStore WorkItemStore  { get;   }
    Boolean IsUsedInWorkItemType  { get;   }
    Boolean IsUsedInGlobalWorkflow  { get;   }
  }
}
