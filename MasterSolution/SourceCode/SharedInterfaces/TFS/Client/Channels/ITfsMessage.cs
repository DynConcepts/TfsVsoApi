using System;
using System.Collections.ObjectModel;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    /// <summary>
    /// Interface ITfsMessage
    /// </summary>
    public interface ITfsMessage
    {
        /// <summary>
        /// Closes this instance.
        /// </summary>
        void Close();
        /// <summary>
        /// Creates the exception.
        /// </summary>
        /// <returns>Exception.</returns>
        Exception CreateException();
        /// <summary>
        /// Gets the body reader.
        /// </summary>
        /// <returns>XmlDictionaryReader.</returns>
        XmlDictionaryReader GetBodyReader();
        /// <summary>
        /// Writes the body contents.
        /// </summary>
        /// <param name="writer">The writer.</param>
        void WriteBodyContents(XmlDictionaryWriter writer);
        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        String Action { get; }
        /// <summary>
        /// Gets the headers.
        /// </summary>
        /// <value>The headers.</value>
        Collection<ITfsMessageHeader> Headers { get; }
        /// <summary>
        /// Gets the is empty.
        /// </summary>
        /// <value>The is empty.</value>
        Boolean IsEmpty { get; }
        /// <summary>
        /// Gets the is fault.
        /// </summary>
        /// <value>The is fault.</value>
        Boolean IsFault { get; }
        /// <summary>
        /// Gets to.
        /// </summary>
        /// <value>To.</value>
        Uri To { get; }
    }
}