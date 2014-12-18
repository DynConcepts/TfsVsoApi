namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IStoredQuery : System.IComparable
  {
    void Reset();
    void Update();
    System.Int32 CompareTo( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQuery storedQuery);
    System.Boolean IsSaved  { get;   }
    System.String Name  { get; set;   }
    System.String QueryText  { get; set;   }
    System.DateTime CreationTime  { get;   }
    System.DateTime CreationTimeUtc  { get;   }
    System.DateTime LastWriteTime  { get;   }
    System.DateTime LastWriteTimeUtc  { get;   }
    System.String Owner  { get;   }
    System.String Description  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryScope QueryScope  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject Project  { get;   }
    System.Guid QueryGuid  { get;   }
  }
}
