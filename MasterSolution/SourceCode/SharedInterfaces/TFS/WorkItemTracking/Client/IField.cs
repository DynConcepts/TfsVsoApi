namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IField
  {
    System.Object Value  { get; set;   }
    System.Object ValueWithServerDefault  { get;   }
    System.Object OriginalValue  { get;   }
    System.Boolean IsChangedInRevision  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition FieldDefinition  { get;   }
    System.Int32 Id  { get;   }
    System.String Name  { get;   }
    System.String ReferenceName  { get;   }
    System.Boolean IsDirty  { get;   }
    System.Boolean IsEditable  { get;   }
    System.Boolean IsComputed  { get;   }
    System.Boolean IsRequired  { get;   }
    System.Boolean IsChangedByUser  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAllowedValuesCollection AllowedValues  { get;   }
    System.Boolean HasAllowedValuesList  { get;   }
    System.Boolean IsLimitedToAllowedValues  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection ProhibitedValues  { get;   }
    System.Boolean HasPatternMatch  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldStatus Status  { get;   }
    System.Boolean IsValid  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem WorkItem  { get;   }
  }
}
