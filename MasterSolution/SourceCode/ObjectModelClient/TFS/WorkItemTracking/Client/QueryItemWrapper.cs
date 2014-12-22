using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class QueryItemWrapper : QueryItemWrapper<IQueryItem, QueryItem>, IQueryItem
    {
        protected QueryItemWrapper(QueryItem instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryItem, QueryItem>(src => src == null ? null : ((QueryItemWrapper) src).r_Instance, src => new QueryItemWrapper(src)); }
    }


    internal abstract class QueryItemWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQueryItem where TInterface : class where TWrapper : class
    {
        IAccessControlList IQueryItem.AccessControlList
        {
            get
            {
                AccessControlList nativeCallResult = r_Instance.AccessControlList;
                IAccessControlList wrappedCallResult = AccessControlListWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IAccessControlListMetadata IQueryItem.AccessControlListMetadata
        {
            get
            {
                AccessControlListMetadata nativeCallResult = r_Instance.AccessControlListMetadata;
                IAccessControlListMetadata wrappedCallResult = AccessControlListMetadataWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IQueryItem.CanManagePermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.CanManagePermissions;
                return nativeCallResult;
            }
            set { r_Instance.CanManagePermissions = value; }
        }

        void IQueryItem.Delete() { r_Instance.Delete(); }

        Guid IQueryItem.Id
        {
            get
            {
                Guid nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        Boolean IQueryItem.IsDeleted
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDeleted;
                return nativeCallResult;
            }
        }

        Boolean IQueryItem.IsDirty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDirty;
                return nativeCallResult;
            }
        }

        Boolean IQueryItem.IsNew
        {
            get
            {
                bool nativeCallResult = r_Instance.IsNew;
                return nativeCallResult;
            }
        }

        Boolean IQueryItem.IsPersonal
        {
            get
            {
                bool nativeCallResult = r_Instance.IsPersonal;
                return nativeCallResult;
            }
        }

        String IQueryItem.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
            set { r_Instance.Name = value; }
        }

        IIdentityDescriptor IQueryItem.OwnerDescriptor
        {
            get
            {
                IdentityDescriptor nativeCallResult = r_Instance.OwnerDescriptor;
                IIdentityDescriptor wrappedCallResult = IdentityDescriptorWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                IdentityDescriptor nativeValue = IdentityDescriptorWrapper.GetInstance(value);

                r_Instance.OwnerDescriptor = nativeValue;
            }
        }

        IQueryFolder IQueryItem.Parent
        {
            get
            {
                QueryFolder nativeCallResult = r_Instance.Parent;
                IQueryFolder wrappedCallResult = QueryFolderWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IQueryItem.Path
        {
            get
            {
                string nativeCallResult = r_Instance.Path;
                return nativeCallResult;
            }
        }

        IProject IQueryItem.Project
        {
            get
            {
                Project nativeCallResult = r_Instance.Project;
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IQueryItem.ResetDirty() { r_Instance.ResetDirty(); }
        void IQueryItem.ResetInternal() { r_Instance.ResetInternal(); }
        protected QueryItemWrapper(QueryItem instance) { r_Instance = instance; }
        protected readonly QueryItem r_Instance;
    }
}