namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQuery
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd[] GetLinkTypes();
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection RunQuery();
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision> RunRevisionQuery();
    System.Int32[] RunRegularQuery();
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkInfo[] RunLinkQuery();
    System.Int32 RunCountQuery();
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult BeginQuery();
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult BeginQuery( System.AsyncCallback callBack);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult BeginRegularQuery();
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult BeginRegularQuery( System.AsyncCallback callback);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult BeginLinkQuery();
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult BeginLinkQuery( System.AsyncCallback callback);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult BeginCountOnlyQuery();
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult BeginCountOnlyQuery( System.AsyncCallback callBack);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection EndQuery( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
    System.Int32[] EndRegularQuery( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkInfo[] EndLinkQuery( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
    System.Int32 EndCountOnlyQuery( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IICancelableAsyncResult car);
    System.Boolean IsBatchReadMode  { get;   }
    System.Boolean IsLinkQuery  { get;   }
    System.Boolean IsTreeQuery  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore WorkItemStore  { get;   }
    System.DateTime AsOfUTC  { get;   }
    System.DateTime AsOf  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IDisplayFieldList DisplayFieldList  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortFieldList SortFieldList  { get;   }
    System.String QueryString  { get;   }
  }
}
