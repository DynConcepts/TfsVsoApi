using System;
using System.Collections;
using System.IO;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface ICategoryCollection
    /// </summary>
    public interface ICategoryCollection : IEnumerable
    {
        /// <summary>
        /// Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String name);
        /// <summary>
        /// Exports this instance.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        XmlDocument Export();
        /// <summary>
        /// Imports the specified stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        void Import(Stream stream);
        /// <summary>
        /// Imports the specified categories.
        /// </summary>
        /// <param name="categories">The categories.</param>
        void Import(String categories);
        /// <summary>
        /// Imports the specified categories element.
        /// </summary>
        /// <param name="categoriesElement">The categories element.</param>
        void Import(XmlElement categoriesElement);
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 Count { get; }
        /// <summary>
        /// Gets the <see cref="ICategory"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ICategory.</returns>
        ICategory this[Int32 index] { get; }
        /// <summary>
        /// Gets the <see cref="ICategory"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>ICategory.</returns>
        ICategory this[String name] { get; }
    }
}