using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class AccessControlListImpl : IAccessControlList
    {
        IEnumerable<IAccessControlEntry> IAccessControlList.AccessControlEntries { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IAccessControlList.InheritPermissions { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IEnumerable<IAccessControlEntry> IAccessControlList.QueryAccessControlEntries(IEnumerable<IIdentityDescriptor> descriptors) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAccessControlEntry IAccessControlList.QueryAccessControlEntry(IIdentityDescriptor descriptor) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IAccessControlList.RemoveAccessControlEntry(IIdentityDescriptor descriptor) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAccessControlEntry IAccessControlList.RemovePermissions(IIdentityDescriptor descriptor, Int32 permissionsToRemove) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<IAccessControlEntry> IAccessControlList.SetAccessControlEntries(IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAccessControlEntry IAccessControlList.SetAccessControlEntry(IAccessControlEntry accessControlEntry, Boolean merge) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAccessControlEntry IAccessControlList.SetPermissions(IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IAccessControlList.Token { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}