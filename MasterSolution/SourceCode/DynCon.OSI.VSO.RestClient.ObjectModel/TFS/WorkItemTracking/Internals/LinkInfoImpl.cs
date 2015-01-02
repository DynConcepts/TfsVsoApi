using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals
{
    /// <summary>
    ///     Class LinkInfoImpl.
    /// </summary>
    internal class LinkInfoImpl : ILinkInfo
    {
        /// <summary>
        ///     Gets or sets the authorized added date.
        /// </summary>
        /// <value>The authorized added date.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        DateTime ILinkInfo.AuthorizedAddedDate { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the authorized removed date.
        /// </summary>
        /// <value>The authorized removed date.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        DateTime ILinkInfo.AuthorizedRemovedDate { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String ILinkInfo.Comment { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the field identifier.
        /// </summary>
        /// <value>The field identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 ILinkInfo.FieldId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}