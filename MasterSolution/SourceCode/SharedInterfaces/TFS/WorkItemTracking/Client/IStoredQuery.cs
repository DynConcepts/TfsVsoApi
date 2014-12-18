using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IStoredQuery : IComparable
  {
    void Reset();
    void Update();
    Int32 CompareTo( IStoredQuery storedQuery);
    Boolean IsSaved  { get;   }
    String Name  { get; set;   }
    String QueryText  { get; set;   }
    DateTime CreationTime  { get;   }
    DateTime CreationTimeUtc  { get;   }
    DateTime LastWriteTime  { get;   }
    DateTime LastWriteTimeUtc  { get;   }
    String Owner  { get;   }
    String Description  { get; set;   }
    IQueryScope QueryScope  { get; set;   }
    IProject Project  { get;   }
    Guid QueryGuid  { get;   }
  }
}
