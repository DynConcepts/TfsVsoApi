using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQuery
  {
    IWorkItemLinkTypeEnd[] GetLinkTypes();
    IWorkItemCollection RunQuery();
    IEnumerable<IRevision> RunRevisionQuery();
    Int32[] RunRegularQuery();
    IWorkItemLinkInfo[] RunLinkQuery();
    Int32 RunCountQuery();
    IICancelableAsyncResult BeginQuery();
    IICancelableAsyncResult BeginQuery( AsyncCallback callBack);
    IICancelableAsyncResult BeginRegularQuery();
    IICancelableAsyncResult BeginRegularQuery( AsyncCallback callback);
    IICancelableAsyncResult BeginLinkQuery();
    IICancelableAsyncResult BeginLinkQuery( AsyncCallback callback);
    IICancelableAsyncResult BeginCountOnlyQuery();
    IICancelableAsyncResult BeginCountOnlyQuery( AsyncCallback callBack);
    IWorkItemCollection EndQuery( IICancelableAsyncResult car);
    Int32[] EndRegularQuery( IICancelableAsyncResult car);
    IWorkItemLinkInfo[] EndLinkQuery( IICancelableAsyncResult car);
    Int32 EndCountOnlyQuery( IICancelableAsyncResult car);
    Boolean IsBatchReadMode  { get;   }
    Boolean IsLinkQuery  { get;   }
    Boolean IsTreeQuery  { get;   }
    IWorkItemStore WorkItemStore  { get;   }
    DateTime AsOfUTC  { get;   }
    DateTime AsOf  { get;   }
    IDisplayFieldList DisplayFieldList  { get;   }
    ISortFieldList SortFieldList  { get;   }
    String QueryString  { get;   }
  }
}
