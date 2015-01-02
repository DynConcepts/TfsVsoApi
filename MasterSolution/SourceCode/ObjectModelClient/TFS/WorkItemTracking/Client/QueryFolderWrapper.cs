using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class QueryFolderWrapper.
    /// </summary>
    internal class QueryFolderWrapper : QueryFolderWrapper<IQueryFolder, QueryFolder>, IQueryFolder, IEnumerable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFolderWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryFolderWrapper(QueryFolder instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryFolder, QueryFolder>(src => src == null ? null : ((QueryFolderWrapper) src).r_Instance, src => new QueryFolderWrapper(src)); }
    }


    /// <summary>
    /// Class QueryFolderWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class QueryFolderWrapper<TWrapper, TInterface> : QueryItemWrapper<TWrapper, TInterface>, IQueryFolder where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void IQueryFolder.Add(IQueryItem item) { r_Instance.Add(QueryItemWrapper.GetInstance(item)); }

        /// <summary>
        /// Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        Boolean IQueryFolder.Contains(String name)
        {
            bool nativeCallResult = r_Instance.Contains(name);
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Boolean.</returns>
        Boolean IQueryFolder.Contains(IQueryItem item)
        {
            bool nativeCallResult = r_Instance.Contains(QueryItemWrapper.GetInstance(item));
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean IQueryFolder.Contains(Guid id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 IQueryFolder.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }


        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = ((IEnumerable) r_Instance).GetEnumerator();
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the is root node.
        /// </summary>
        /// <value>The is root node.</value>
        Boolean IQueryFolder.IsRootNode
        {
            get
            {
                bool nativeCallResult = r_Instance.IsRootNode;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="IQueryItem" /> with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryItem.</returns>
        IQueryItem IQueryFolder.this[Guid id]
        {
            get
            {
                QueryItem nativeCallResult = r_Instance[id];
                IQueryItem wrappedCallResult = QueryItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="IQueryItem" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IQueryItem.</returns>
        IQueryItem IQueryFolder.this[String name]
        {
            get
            {
                QueryItem nativeCallResult = r_Instance[name];
                IQueryItem wrappedCallResult = QueryItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFolderWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryFolderWrapper(QueryFolder instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly QueryFolder r_Instance;
    }
}