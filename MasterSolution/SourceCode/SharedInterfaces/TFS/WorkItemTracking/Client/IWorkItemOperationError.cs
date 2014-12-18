using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemOperationError
  {
    Int32 Id  { get;   }
    Exception Exception  { get;   }
  }
}
