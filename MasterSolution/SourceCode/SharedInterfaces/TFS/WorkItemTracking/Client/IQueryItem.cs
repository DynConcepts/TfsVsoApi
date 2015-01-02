using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IQueryItem
    /// </summary>
    public interface IQueryItem
    {
        /// <summary>
        /// Deletes this instance.
        /// </summary>
        void Delete();
        /// <summary>
        /// Resets the dirty.
        /// </summary>
        void ResetDirty();
        /// <summary>
        /// Resets the internal.
        /// </summary>
        void ResetInternal();
        /// <summary>
        /// Gets the access control list.
        /// </summary>
        /// <value>The access control list.</value>
        IAccessControlList AccessControlList { get; }
        /// <summary>
        /// Gets the access control list metadata.
        /// </summary>
        /// <value>The access control list metadata.</value>
        IAccessControlListMetadata AccessControlListMetadata { get; }
        /// <summary>
        /// Gets or sets the can manage permissions.
        /// </summary>
        /// <value>The can manage permissions.</value>
        Boolean CanManagePermissions { get; set; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid Id { get; }
        /// <summary>
        /// Gets the is deleted.
        /// </summary>
        /// <value>The is deleted.</value>
        Boolean IsDeleted { get; }
        /// <summary>
        /// Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        Boolean IsDirty { get; }
        /// <summary>
        /// Gets the is new.
        /// </summary>
        /// <value>The is new.</value>
        Boolean IsNew { get; }
        /// <summary>
        /// Gets the is personal.
        /// </summary>
        /// <value>The is personal.</value>
        Boolean IsPersonal { get; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; set; }
        /// <summary>
        /// Gets or sets the owner descriptor.
        /// </summary>
        /// <value>The owner descriptor.</value>
        IIdentityDescriptor OwnerDescriptor { get; set; }
        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        IQueryFolder Parent { get; }
        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        String Path { get; }
        /// <summary>
        /// Gets the project.
        /// </summary>
        /// <value>The project.</value>
        IProject Project { get; }
    }
}