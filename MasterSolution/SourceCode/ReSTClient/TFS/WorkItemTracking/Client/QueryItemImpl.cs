using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryItemImpl : IQueryItem
    {
        IAccessControlList IQueryItem.AccessControlList { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IAccessControlListMetadata IQueryItem.AccessControlListMetadata { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQueryItem.CanManagePermissions { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IQueryItem.Delete() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Guid IQueryItem.Id { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQueryItem.IsDeleted { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQueryItem.IsDirty { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQueryItem.IsNew { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQueryItem.IsPersonal { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IQueryItem.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IIdentityDescriptor IQueryItem.OwnerDescriptor { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IQueryFolder IQueryItem.Parent { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IQueryItem.Path { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IProject IQueryItem.Project { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IQueryItem.ResetDirty() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IQueryItem.ResetInternal() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}