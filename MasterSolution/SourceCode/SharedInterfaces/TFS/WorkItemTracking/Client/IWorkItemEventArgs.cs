using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemEventArgs
  {
    IField Field  { get;   }
    Object Object  { get;   }
  }
}
