using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class QueryFolderWrapper : QueryFolderWrapper<IQueryFolder, QueryFolder>, IQueryFolder, IEnumerable
    {
        protected QueryFolderWrapper(QueryFolder instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryFolder, QueryFolder>(src => src==null ? null : ((QueryFolderWrapper) src).r_Instance, src => new QueryFolderWrapper(src)); }
    }


    internal class QueryFolderWrapper<TWrapper, TInterface> : QueryItemWrapper<TWrapper, TInterface>, IQueryFolder where TInterface : class where TWrapper : class
    {

        void IQueryFolder.Add(IQueryItem item) { r_Instance.Add(QueryItemWrapper.GetInstance(item)); }

        Boolean IQueryFolder.Contains(String name)
        {
            bool nativeCallResult = r_Instance.Contains(name);
            return nativeCallResult;
        }


        Boolean IQueryFolder.Contains(IQueryItem item)
        {
            bool nativeCallResult = r_Instance.Contains(QueryItemWrapper.GetInstance(item));
            return nativeCallResult;
        }


        Boolean IQueryFolder.Contains(Guid id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }

        Int32 IQueryFolder.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = ((IEnumerable) r_Instance).GetEnumerator();
            return nativeCallResult;
        }

        Boolean IQueryFolder.IsRootNode
        {
            get
            {
                bool nativeCallResult = r_Instance.IsRootNode;
                return nativeCallResult;
            }
        }

        IQueryItem IQueryFolder.this[Guid id]
        {
            get
            {
                QueryItem nativeCallResult = r_Instance[id];
                IQueryItem wrappedCallResult = QueryItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IQueryItem IQueryFolder.this[String name]
        {
            get
            {
                QueryItem nativeCallResult = r_Instance[name];
                IQueryItem wrappedCallResult = QueryItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected QueryFolderWrapper(QueryFolder instance) : base(instance) { r_Instance = instance; }
        protected new readonly QueryFolder r_Instance;
    }
}