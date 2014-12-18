using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IField
  {
    Object Value  { get; set;   }
    Object ValueWithServerDefault  { get;   }
    Object OriginalValue  { get;   }
    Boolean IsChangedInRevision  { get;   }
    IFieldDefinition FieldDefinition  { get;   }
    Int32 Id  { get;   }
    String Name  { get;   }
    String ReferenceName  { get;   }
    Boolean IsDirty  { get;   }
    Boolean IsEditable  { get;   }
    Boolean IsComputed  { get;   }
    Boolean IsRequired  { get;   }
    Boolean IsChangedByUser  { get;   }
    IAllowedValuesCollection AllowedValues  { get;   }
    Boolean HasAllowedValuesList  { get;   }
    Boolean IsLimitedToAllowedValues  { get;   }
    IValuesCollection ProhibitedValues  { get;   }
    Boolean HasPatternMatch  { get;   }
    IFieldStatus Status  { get;   }
    Boolean IsValid  { get;   }
    IWorkItem WorkItem  { get;   }
  }
}
