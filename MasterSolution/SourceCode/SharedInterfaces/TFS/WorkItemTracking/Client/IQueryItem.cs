namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryItem
  {
    void ResetInternal();
    void Delete();
    void ResetDirty();
    System.Guid Id  { get;   }
    System.String Name  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryFolder Parent  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject Project  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor OwnerDescriptor  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlList AccessControlList  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata AccessControlListMetadata  { get;   }
    System.Boolean CanManagePermissions  { get; set;   }
    System.Boolean IsPersonal  { get;   }
    System.Boolean IsDeleted  { get;   }
    System.Boolean IsNew  { get;   }
    System.Boolean IsDirty  { get;   }
    System.String Path  { get;   }
  }
}
