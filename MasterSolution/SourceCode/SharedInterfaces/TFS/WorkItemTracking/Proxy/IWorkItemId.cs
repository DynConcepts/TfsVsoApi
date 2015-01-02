using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IWorkItemId
    /// </summary>
    public interface IWorkItemId
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 Id { get; set; }
        /// <summary>
        /// Gets or sets the row version.
        /// </summary>
        /// <value>The row version.</value>
        Int64 RowVersion { get; set; }
    }
}