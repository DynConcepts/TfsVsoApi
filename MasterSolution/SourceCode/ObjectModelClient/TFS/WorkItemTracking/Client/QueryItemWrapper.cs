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
    /// <summary>
    /// Class QueryItemWrapper.
    /// </summary>
    internal class QueryItemWrapper : QueryItemWrapper<IQueryItem, QueryItem>, IQueryItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryItemWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryItemWrapper(QueryItem instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryItem, QueryItem>(src => src == null ? null : ((QueryItemWrapper) src).r_Instance, src => new QueryItemWrapper(src)); }
    }


    /// <summary>
    /// Class QueryItemWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class QueryItemWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQueryItem where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the access control list.
        /// </summary>
        /// <value>The access control list.</value>
        IAccessControlList IQueryItem.AccessControlList
        {
            get
            {
                AccessControlList nativeCallResult = r_Instance.AccessControlList;
                IAccessControlList wrappedCallResult = AccessControlListWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the access control list metadata.
        /// </summary>
        /// <value>The access control list metadata.</value>
        IAccessControlListMetadata IQueryItem.AccessControlListMetadata
        {
            get
            {
                AccessControlListMetadata nativeCallResult = r_Instance.AccessControlListMetadata;
                IAccessControlListMetadata wrappedCallResult = AccessControlListMetadataWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the can manage permissions.
        /// </summary>
        /// <value>The can manage permissions.</value>
        Boolean IQueryItem.CanManagePermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.CanManagePermissions;
                return nativeCallResult;
            }
            set { r_Instance.CanManagePermissions = value; }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        void IQueryItem.Delete() { r_Instance.Delete(); }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid IQueryItem.Id
        {
            get
            {
                Guid nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is deleted.
        /// </summary>
        /// <value>The is deleted.</value>
        Boolean IQueryItem.IsDeleted
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDeleted;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        Boolean IQueryItem.IsDirty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDirty;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is new.
        /// </summary>
        /// <value>The is new.</value>
        Boolean IQueryItem.IsNew
        {
            get
            {
                bool nativeCallResult = r_Instance.IsNew;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is personal.
        /// </summary>
        /// <value>The is personal.</value>
        Boolean IQueryItem.IsPersonal
        {
            get
            {
                bool nativeCallResult = r_Instance.IsPersonal;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        String IQueryItem.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
            set { r_Instance.Name = value; }
        }

        /// <summary>
        /// Gets or sets the owner descriptor.
        /// </summary>
        /// <value>The owner descriptor.</value>
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

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        IQueryFolder IQueryItem.Parent
        {
            get
            {
                QueryFolder nativeCallResult = r_Instance.Parent;
                IQueryFolder wrappedCallResult = QueryFolderWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        String IQueryItem.Path
        {
            get
            {
                string nativeCallResult = r_Instance.Path;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the project.
        /// </summary>
        /// <value>The project.</value>
        IProject IQueryItem.Project
        {
            get
            {
                Project nativeCallResult = r_Instance.Project;
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Resets the dirty.
        /// </summary>
        void IQueryItem.ResetDirty() { r_Instance.ResetDirty(); }
        /// <summary>
        /// Resets the internal.
        /// </summary>
        void IQueryItem.ResetInternal() { r_Instance.ResetInternal(); }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryItemWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryItemWrapper(QueryItem instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly QueryItem r_Instance;
    }
}