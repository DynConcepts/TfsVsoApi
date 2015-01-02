using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class QueryItemImpl.
    /// </summary>
    internal class QueryItemImpl : IQueryItem
    {
        /// <summary>
        ///     Gets the access control list.
        /// </summary>
        /// <value>The access control list.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessControlList IQueryItem.AccessControlList { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the access control list metadata.
        /// </summary>
        /// <value>The access control list metadata.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessControlListMetadata IQueryItem.AccessControlListMetadata { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the can manage permissions.
        /// </summary>
        /// <value>The can manage permissions.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IQueryItem.CanManagePermissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Deletes this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryItem.Delete() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Guid IQueryItem.Id { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is deleted.
        /// </summary>
        /// <value>The is deleted.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryItem.IsDeleted { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryItem.IsDirty { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is new.
        /// </summary>
        /// <value>The is new.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryItem.IsNew { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is personal.
        /// </summary>
        /// <value>The is personal.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryItem.IsPersonal { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IQueryItem.Name { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the owner descriptor.
        /// </summary>
        /// <value>The owner descriptor.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IIdentityDescriptor IQueryItem.OwnerDescriptor { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryFolder IQueryItem.Parent { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the path.
        /// </summary>
        /// <value>The path.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IQueryItem.Path { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the project.
        /// </summary>
        /// <value>The project.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IProject IQueryItem.Project { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Resets the dirty.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryItem.ResetDirty() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Resets the internal.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryItem.ResetInternal() { throw new ToBeImplementedException(); }
    }
}