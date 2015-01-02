using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class QueryFolderContentsChangedEventArgsWrapper.
    /// </summary>
    internal class QueryFolderContentsChangedEventArgsWrapper : QueryFolderContentsChangedEventArgsWrapper<IQueryFolderContentsChangedEventArgs, QueryFolderContentsChangedEventArgs>, IQueryFolderContentsChangedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFolderContentsChangedEventArgsWrapper"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="QueryFolderContentsChangedEventArgs"/> instance containing the event data.</param>
        protected QueryFolderContentsChangedEventArgsWrapper(QueryFolderContentsChangedEventArgs instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryFolderContentsChangedEventArgs, QueryFolderContentsChangedEventArgs>(src => src == null ? null : ((QueryFolderContentsChangedEventArgsWrapper) src).r_Instance, src => new QueryFolderContentsChangedEventArgsWrapper(src)); }
    }


    /// <summary>
    /// Class QueryFolderContentsChangedEventArgsWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class QueryFolderContentsChangedEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQueryFolderContentsChangedEventArgs where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        IQueryFolderAction IQueryFolderContentsChangedEventArgs.Action
        {
            get
            {
                QueryFolderAction nativeCallResult = r_Instance.Action;
                IQueryFolderAction wrappedCallResult = QueryFolderActionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the query item.
        /// </summary>
        /// <value>The query item.</value>
        IQueryItem IQueryFolderContentsChangedEventArgs.QueryItem
        {
            get
            {
                QueryItem nativeCallResult = r_Instance.QueryItem;
                IQueryItem wrappedCallResult = QueryItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFolderContentsChangedEventArgsWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="QueryFolderContentsChangedEventArgs"/> instance containing the event data.</param>
        protected QueryFolderContentsChangedEventArgsWrapper(QueryFolderContentsChangedEventArgs instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly QueryFolderContentsChangedEventArgs r_Instance;
    }
}