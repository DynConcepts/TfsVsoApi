using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface IIWorkItemRelation
  {
    Int32 SourceID  { get; set;   }
    Int32 TargetID  { get; set;   }
    Int32 LinkTypeID  { get; set;   }
    Boolean IsLocked  { get; set;   }
  }
}
