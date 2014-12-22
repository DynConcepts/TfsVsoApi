using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryItemImpl : IQueryItem
    {
        IAccessControlList IQueryItem.AccessControlList { get { throw new ToBeImplementedException(); } }
        IAccessControlListMetadata IQueryItem.AccessControlListMetadata { get { throw new ToBeImplementedException(); } }
        Boolean IQueryItem.CanManagePermissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IQueryItem.Delete() { throw new ToBeImplementedException(); }
        Guid IQueryItem.Id { get { throw new ToBeImplementedException(); } }
        Boolean IQueryItem.IsDeleted { get { throw new ToBeImplementedException(); } }
        Boolean IQueryItem.IsDirty { get { throw new ToBeImplementedException(); } }
        Boolean IQueryItem.IsNew { get { throw new ToBeImplementedException(); } }
        Boolean IQueryItem.IsPersonal { get { throw new ToBeImplementedException(); } }
        String IQueryItem.Name { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IIdentityDescriptor IQueryItem.OwnerDescriptor { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IQueryFolder IQueryItem.Parent { get { throw new ToBeImplementedException(); } }
        String IQueryItem.Path { get { throw new ToBeImplementedException(); } }
        IProject IQueryItem.Project { get { throw new ToBeImplementedException(); } }
        void IQueryItem.ResetDirty() { throw new ToBeImplementedException(); }
        void IQueryItem.ResetInternal() { throw new ToBeImplementedException(); }
    }
}