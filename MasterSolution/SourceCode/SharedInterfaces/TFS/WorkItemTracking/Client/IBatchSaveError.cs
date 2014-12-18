using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IBatchSaveError
  {
    IWorkItem WorkItem  { get;   }
    Exception Exception  { get;   }
  }
}
