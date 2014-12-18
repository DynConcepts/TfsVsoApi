namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IAccessControlList
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry RemovePermissions( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor, System.Int32 permissionsToRemove);
    System.Boolean RemoveAccessControlEntry( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry SetPermissions( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor, System.Int32 allow, System.Int32 deny, System.Boolean merge);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry SetAccessControlEntry( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry accessControlEntry, System.Boolean merge);
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry> SetAccessControlEntries( System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry> accessControlEntries, System.Boolean merge);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry QueryAccessControlEntry( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor descriptor);
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry> QueryAccessControlEntries( System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor> descriptors);
    System.Boolean InheritPermissions  { get; set;   }
    System.String Token  { get; set;   }
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessControlEntry> AccessControlEntries  { get;   }
  }
}
