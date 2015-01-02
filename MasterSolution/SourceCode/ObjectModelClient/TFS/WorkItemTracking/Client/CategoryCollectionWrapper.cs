using System;
using System.Collections;
using System.IO;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class CategoryCollectionWrapper.
    /// </summary>
    internal class CategoryCollectionWrapper : CategoryCollectionWrapper<ICategoryCollection, CategoryCollection>, ICategoryCollection, IEnumerable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CategoryCollectionWrapper(CategoryCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICategoryCollection, CategoryCollection>(src => src == null ? null : ((CategoryCollectionWrapper) src).r_Instance, src => new CategoryCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class CategoryCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CategoryCollectionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICategoryCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        Boolean ICategoryCollection.Contains(String name)
        {
            bool nativeCallResult = r_Instance.Contains(name);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 ICategoryCollection.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Exports this instance.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        XmlDocument ICategoryCollection.Export()
        {
            XmlDocument nativeCallResult = r_Instance.Export();
            return nativeCallResult;
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = ((IEnumerable) r_Instance).GetEnumerator();
            var mappedCallResult = new EnumeratorWrapper<ICategory>(nativeCallResult, o => CategoryWrapper.GetWrapper((Category) o));
            return mappedCallResult;
        }

        /// <summary>
        /// Imports the specified stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        void ICategoryCollection.Import(Stream stream) { r_Instance.Import(stream); }

        /// <summary>
        /// Imports the specified categories.
        /// </summary>
        /// <param name="categories">The categories.</param>
        void ICategoryCollection.Import(String categories) { r_Instance.Import(categories); }

        /// <summary>
        /// Imports the specified categories element.
        /// </summary>
        /// <param name="categoriesElement">The categories element.</param>
        void ICategoryCollection.Import(XmlElement categoriesElement) { r_Instance.Import(categoriesElement); }


        /// <summary>
        /// Gets the <see cref="ICategory" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ICategory.</returns>
        ICategory ICategoryCollection.this[Int32 index]
        {
            get
            {
                Category nativeCallResult = r_Instance[index];
                ICategory wrappedCallResult = CategoryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="ICategory" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>ICategory.</returns>
        ICategory ICategoryCollection.this[String name]
        {
            get
            {
                Category nativeCallResult = r_Instance[name];
                ICategory wrappedCallResult = CategoryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CategoryCollectionWrapper(CategoryCollection instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly CategoryCollection r_Instance;
    }
}