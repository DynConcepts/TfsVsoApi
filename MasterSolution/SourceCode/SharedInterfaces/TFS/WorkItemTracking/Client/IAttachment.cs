using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IAttachment
  {
    Boolean IsSaved  { get;   }
    String Name  { get;   }
    DateTime CreationTime  { get;   }
    DateTime CreationTimeUtc  { get;   }
    DateTime AttachedTime  { get;   }
    DateTime AttachedTimeUtc  { get;   }
    DateTime LastWriteTime  { get;   }
    DateTime LastWriteTimeUtc  { get;   }
    String Extension  { get;   }
    Int64 Length  { get;   }
    String Comment  { get; set;   }
    Int32 Id  { get;   }
    String FileGuid  { get;   }
    Uri Uri  { get;   }
  }
}
