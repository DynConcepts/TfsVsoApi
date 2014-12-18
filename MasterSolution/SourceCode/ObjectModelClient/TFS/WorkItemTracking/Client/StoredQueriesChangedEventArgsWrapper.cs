using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class StoredQueriesChangedEventArgsWrapper : StoredQueriesChangedEventArgsWrapper<IStoredQueriesChangedEventArgs, StoredQueriesChangedEventArgs>, IStoredQueriesChangedEventArgs
    {
        protected StoredQueriesChangedEventArgsWrapper(StoredQueriesChangedEventArgs instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IStoredQueriesChangedEventArgs, StoredQueriesChangedEventArgs>(src => ((StoredQueriesChangedEventArgsWrapper) src).r_Instance, src => new StoredQueriesChangedEventArgsWrapper(src)); }
    }


    internal class StoredQueriesChangedEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IStoredQueriesChangedEventArgs where TInterface : class where TWrapper : class
    {
        IStoredQuery IStoredQueriesChangedEventArgs.SourceStoredQuery
        {
            get
            {
                StoredQuery nativeCallResult = r_Instance.SourceStoredQuery;
                IStoredQuery wrappedCallResult = StoredQueryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IStoredQueriesAction IStoredQueriesChangedEventArgs.StoredQueriesAction
        {
            get
            {
                StoredQueriesAction nativeCallResult = r_Instance.StoredQueriesAction;
                IStoredQueriesAction wrappedCallResult = StoredQueriesActionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected StoredQueriesChangedEventArgsWrapper(StoredQueriesChangedEventArgs instance) { r_Instance = instance; }
        protected readonly StoredQueriesChangedEventArgs r_Instance;
    }
}