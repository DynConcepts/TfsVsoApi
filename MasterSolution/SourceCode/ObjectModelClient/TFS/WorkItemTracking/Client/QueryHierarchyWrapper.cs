using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class QueryHierarchyWrapper : QueryHierarchyWrapper<IQueryHierarchy, QueryHierarchy>, IQueryHierarchy
    {
        protected QueryHierarchyWrapper(QueryHierarchy instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryHierarchy, QueryHierarchy>(src => ((QueryHierarchyWrapper) src).r_Instance, src => new QueryHierarchyWrapper(src)); }
    }


    internal class QueryHierarchyWrapper<TWrapper, TInterface> : QueryFolderWrapper<TWrapper, TInterface>, IQueryHierarchy where TInterface : class where TWrapper : class
    {

        IQueryItem IQueryHierarchy.Find(Guid id)
        {
            QueryItem nativeCallResult = r_Instance.Find(id);
            IQueryItem wrappedCallResult = QueryItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IQueryHierarchyRefreshData IQueryHierarchy.GetRefreshData()
        {
            QueryHierarchyRefreshData nativeCallResult = r_Instance.GetRefreshData();
            IQueryHierarchyRefreshData wrappedCallResult = QueryHierarchyRefreshDataWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        void IQueryHierarchy.Refresh(IQueryHierarchyRefreshData refreshData) { r_Instance.Refresh(QueryHierarchyRefreshDataWrapper.GetInstance(refreshData)); }



        void IQueryHierarchy.Refresh() { r_Instance.Refresh(); }
        void IQueryHierarchy.Reset() { r_Instance.Reset(); }
        void IQueryHierarchy.Save() { r_Instance.Save(); }

        Boolean IQueryHierarchy.SupportsFolders
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsFolders;
                return nativeCallResult;
            }
        }

        Boolean IQueryHierarchy.SupportsPermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsPermissions;
                return nativeCallResult;
            }
        }

        protected QueryHierarchyWrapper(QueryHierarchy instance) : base(instance) { r_Instance = instance; }
        protected new readonly QueryHierarchy r_Instance;
    }
}