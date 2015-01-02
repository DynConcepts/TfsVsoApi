using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    /// <summary>
    /// Interface ITfsMessageHeader
    /// </summary>
    public interface ITfsMessageHeader
    {
        /// <summary>
        /// Gets the reader.
        /// </summary>
        /// <returns>XmlDictionaryReader.</returns>
        XmlDictionaryReader GetReader();
        /// <summary>
        /// Writes the specified writer.
        /// </summary>
        /// <param name="writer">The writer.</param>
        void Write(XmlDictionaryWriter writer);
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the namespace.
        /// </summary>
        /// <value>The namespace.</value>
        String Namespace { get; }
    }
}