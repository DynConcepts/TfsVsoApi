using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IQueryItem
    {
        void Delete();
        void ResetDirty();
        void ResetInternal();
        IAccessControlList AccessControlList { get; }
        IAccessControlListMetadata AccessControlListMetadata { get; }
        Boolean CanManagePermissions { get; set; }
        Guid Id { get; }
        Boolean IsDeleted { get; }
        Boolean IsDirty { get; }
        Boolean IsNew { get; }
        Boolean IsPersonal { get; }
        String Name { get; set; }
        IIdentityDescriptor OwnerDescriptor { get; set; }
        IQueryFolder Parent { get; }
        String Path { get; }
        IProject Project { get; }
    }
}