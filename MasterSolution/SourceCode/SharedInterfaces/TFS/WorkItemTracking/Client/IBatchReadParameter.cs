namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IBatchReadParameter
  {
    System.Int32 Id  { get;   }
    System.Int32 Revision  { get;   }
    System.Int32 ProjectHint  { get; set;   }
  }
}
