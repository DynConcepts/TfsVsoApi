using System;
using System.Collections;
using System.IO;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class CategoryCollectionImpl.
    /// </summary>
    internal class CategoryCollectionImpl : ICategoryCollection, IEnumerable
    {
        /// <summary>
        ///     Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ICategoryCollection.Contains(String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 ICategoryCollection.Count { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Exports this instance.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        XmlDocument ICategoryCollection.Export() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICategoryCollection.Import(Stream stream) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified categories.
        /// </summary>
        /// <param name="categories">The categories.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICategoryCollection.Import(String categories) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified categories element.
        /// </summary>
        /// <param name="categoriesElement">The categories element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICategoryCollection.Import(XmlElement categoriesElement) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the <see cref="ICategory" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ICategory.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICategory ICategoryCollection.this[Int32 index] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="ICategory" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>ICategory.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICategory ICategoryCollection.this[String name] { get { throw new ToBeImplementedException(); } }
    }
}