using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IRelatedLink : ILink
  {
    Int32 RelatedWorkItemId  { get;   }
    IWorkItemLinkTypeEnd LinkTypeEnd  { get;   }
  }
}
