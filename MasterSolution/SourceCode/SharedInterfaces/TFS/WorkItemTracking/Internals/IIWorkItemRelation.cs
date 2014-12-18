namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface IIWorkItemRelation
  {
    System.Int32 SourceID  { get; set;   }
    System.Int32 TargetID  { get; set;   }
    System.Int32 LinkTypeID  { get; set;   }
    System.Boolean IsLocked  { get; set;   }
  }
}
