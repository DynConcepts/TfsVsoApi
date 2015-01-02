using System.Xml.Serialization;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IRowSet
    /// </summary>
    public interface IRowSet : IIRowSet, IXmlSerializable
    {
        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <value>The columns.</value>
        IRowSetColumn[] Columns { get; }
    }
}