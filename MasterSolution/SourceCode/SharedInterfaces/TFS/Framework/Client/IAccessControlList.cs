using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IAccessControlList
  {
    IAccessControlEntry RemovePermissions( IIdentityDescriptor descriptor, Int32 permissionsToRemove);
    Boolean RemoveAccessControlEntry( IIdentityDescriptor descriptor);
    IAccessControlEntry SetPermissions( IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge);
    IAccessControlEntry SetAccessControlEntry( IAccessControlEntry accessControlEntry, Boolean merge);
    IEnumerable<IAccessControlEntry> SetAccessControlEntries( IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge);
    IAccessControlEntry QueryAccessControlEntry( IIdentityDescriptor descriptor);
    IEnumerable<IAccessControlEntry> QueryAccessControlEntries( IEnumerable<IIdentityDescriptor> descriptors);
    Boolean InheritPermissions  { get; set;   }
    String Token  { get; set;   }
    IEnumerable<IAccessControlEntry> AccessControlEntries  { get;   }
  }
}
