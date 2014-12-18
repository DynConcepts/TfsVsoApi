using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryItem
  {
    void ResetInternal();
    void Delete();
    void ResetDirty();
    Guid Id  { get;   }
    String Name  { get; set;   }
    IQueryFolder Parent  { get;   }
    IProject Project  { get;   }
    IIdentityDescriptor OwnerDescriptor  { get; set;   }
    IAccessControlList AccessControlList  { get;   }
    IAccessControlListMetadata AccessControlListMetadata  { get;   }
    Boolean CanManagePermissions  { get; set;   }
    Boolean IsPersonal  { get;   }
    Boolean IsDeleted  { get;   }
    Boolean IsNew  { get;   }
    Boolean IsDirty  { get;   }
    String Path  { get;   }
  }
}
