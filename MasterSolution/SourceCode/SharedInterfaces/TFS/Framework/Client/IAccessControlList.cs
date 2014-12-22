using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface IAccessControlList
    {
        IEnumerable<IAccessControlEntry> QueryAccessControlEntries(IEnumerable<IIdentityDescriptor> descriptors);
        IAccessControlEntry QueryAccessControlEntry(IIdentityDescriptor descriptor);
        Boolean RemoveAccessControlEntry(IIdentityDescriptor descriptor);
        IAccessControlEntry RemovePermissions(IIdentityDescriptor descriptor, Int32 permissionsToRemove);
        IEnumerable<IAccessControlEntry> SetAccessControlEntries(IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge);
        IAccessControlEntry SetAccessControlEntry(IAccessControlEntry accessControlEntry, Boolean merge);
        IAccessControlEntry SetPermissions(IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge);
        IEnumerable<IAccessControlEntry> AccessControlEntries { get; }
        Boolean InheritPermissions { get; set; }
        String Token { get; set; }
    }
}