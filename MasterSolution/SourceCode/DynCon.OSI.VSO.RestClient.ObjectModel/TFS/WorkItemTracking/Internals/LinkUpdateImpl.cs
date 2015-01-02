using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals
{
    /// <summary>
    ///     Class LinkUpdateImpl.
    /// </summary>
    internal class LinkUpdateImpl : ILinkUpdate
    {
        /// <summary>
        ///     Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String ILinkUpdate.Comment { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean ILinkUpdate.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the mask.
        /// </summary>
        /// <value>The mask.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ILinkProperties ILinkUpdate.Mask { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Submits the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ILinkUpdate.Submit(XmlElement element) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Submits the specified li.
        /// </summary>
        /// <param name="li">The li.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ILinkUpdate.Submit(ILinkInfo li) { throw new ToBeImplementedException(); }
    }
}