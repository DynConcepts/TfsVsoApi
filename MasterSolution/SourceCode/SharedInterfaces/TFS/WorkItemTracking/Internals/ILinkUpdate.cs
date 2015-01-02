using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    /// <summary>
    /// Interface ILinkUpdate
    /// </summary>
    public interface ILinkUpdate
    {
        /// <summary>
        /// Submits the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        void Submit(XmlElement element);
        /// <summary>
        /// Submits the specified li.
        /// </summary>
        /// <param name="li">The li.</param>
        void Submit(ILinkInfo li);
        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        String Comment { get; set; }
        /// <summary>
        /// Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        Boolean IsLocked { get; set; }
        /// <summary>
        /// Gets the mask.
        /// </summary>
        /// <value>The mask.</value>
        ILinkProperties Mask { get; }
    }
}