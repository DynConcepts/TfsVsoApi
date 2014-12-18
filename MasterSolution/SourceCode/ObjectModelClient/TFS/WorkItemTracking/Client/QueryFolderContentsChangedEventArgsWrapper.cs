using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class QueryFolderContentsChangedEventArgsWrapper : QueryFolderContentsChangedEventArgsWrapper<IQueryFolderContentsChangedEventArgs, QueryFolderContentsChangedEventArgs>, IQueryFolderContentsChangedEventArgs
    {
        protected QueryFolderContentsChangedEventArgsWrapper(QueryFolderContentsChangedEventArgs instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryFolderContentsChangedEventArgs, QueryFolderContentsChangedEventArgs>(src => src==null ? null : ((QueryFolderContentsChangedEventArgsWrapper) src).r_Instance, src => new QueryFolderContentsChangedEventArgsWrapper(src)); }
    }


    internal class QueryFolderContentsChangedEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQueryFolderContentsChangedEventArgs where TInterface : class where TWrapper : class
    {
        IQueryFolderAction IQueryFolderContentsChangedEventArgs.Action
        {
            get
            {
                QueryFolderAction nativeCallResult = r_Instance.Action;
                IQueryFolderAction wrappedCallResult = QueryFolderActionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IQueryItem IQueryFolderContentsChangedEventArgs.QueryItem
        {
            get
            {
                QueryItem nativeCallResult = r_Instance.QueryItem;
                IQueryItem wrappedCallResult = QueryItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected QueryFolderContentsChangedEventArgsWrapper(QueryFolderContentsChangedEventArgs instance) { r_Instance = instance; }
        protected readonly QueryFolderContentsChangedEventArgs r_Instance;
    }
}