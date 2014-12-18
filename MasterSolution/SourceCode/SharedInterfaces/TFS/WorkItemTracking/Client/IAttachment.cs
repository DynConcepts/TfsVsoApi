namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IAttachment
  {
    System.Boolean IsSaved  { get;   }
    System.String Name  { get;   }
    System.DateTime CreationTime  { get;   }
    System.DateTime CreationTimeUtc  { get;   }
    System.DateTime AttachedTime  { get;   }
    System.DateTime AttachedTimeUtc  { get;   }
    System.DateTime LastWriteTime  { get;   }
    System.DateTime LastWriteTimeUtc  { get;   }
    System.String Extension  { get;   }
    System.Int64 Length  { get;   }
    System.String Comment  { get; set;   }
    System.Int32 Id  { get;   }
    System.String FileGuid  { get;   }
    System.Uri Uri  { get;   }
  }
}
