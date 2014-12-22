using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class QueryHierarchyRefreshDataWrapper : QueryHierarchyRefreshDataWrapper<IQueryHierarchyRefreshData, QueryHierarchyRefreshData>, IQueryHierarchyRefreshData
    {
        protected QueryHierarchyRefreshDataWrapper(QueryHierarchyRefreshData instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryHierarchyRefreshData, QueryHierarchyRefreshData>(src => src == null ? null : ((QueryHierarchyRefreshDataWrapper) src).r_Instance, src => new QueryHierarchyRefreshDataWrapper(src)); }
    }


    internal class QueryHierarchyRefreshDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQueryHierarchyRefreshData where TInterface : class where TWrapper : class
    {
        IQueryHierarchy IQueryHierarchyRefreshData.Hierarchy
        {
            get
            {
                QueryHierarchy nativeCallResult = r_Instance.Hierarchy;
                IQueryHierarchy wrappedCallResult = QueryHierarchyWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IQueryHierarchyRefreshData.IsLegacy
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLegacy;
                return nativeCallResult;
            }
        }

        ArrayList IQueryHierarchyRefreshData.LegacyQueries
        {
            get
            {
                ArrayList nativeCallResult = r_Instance.LegacyQueries;
                return nativeCallResult;
            }
        }

        IRowSetCollection IQueryHierarchyRefreshData.QueriesDataSet
        {
            get
            {
                RowSetCollection nativeCallResult = r_Instance.QueriesDataSet;
                IRowSetCollection wrappedCallResult = RowSetCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected QueryHierarchyRefreshDataWrapper(QueryHierarchyRefreshData instance) { r_Instance = instance; }
        protected readonly QueryHierarchyRefreshData r_Instance;
    }
}