using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class AccessControlListImpl : IAccessControlList
    {
        IEnumerable<IAccessControlEntry> IAccessControlList.AccessControlEntries { get { throw new ToBeImplementedException(); } }
        Boolean IAccessControlList.InheritPermissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IEnumerable<IAccessControlEntry> IAccessControlList.QueryAccessControlEntries(IEnumerable<IIdentityDescriptor> descriptors) { throw new ToBeImplementedException(); }
        IAccessControlEntry IAccessControlList.QueryAccessControlEntry(IIdentityDescriptor descriptor) { throw new ToBeImplementedException(); }
        Boolean IAccessControlList.RemoveAccessControlEntry(IIdentityDescriptor descriptor) { throw new ToBeImplementedException(); }
        IAccessControlEntry IAccessControlList.RemovePermissions(IIdentityDescriptor descriptor, Int32 permissionsToRemove) { throw new ToBeImplementedException(); }
        IEnumerable<IAccessControlEntry> IAccessControlList.SetAccessControlEntries(IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge) { throw new ToBeImplementedException(); }
        IAccessControlEntry IAccessControlList.SetAccessControlEntry(IAccessControlEntry accessControlEntry, Boolean merge) { throw new ToBeImplementedException(); }
        IAccessControlEntry IAccessControlList.SetPermissions(IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge) { throw new ToBeImplementedException(); }
        String IAccessControlList.Token { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}