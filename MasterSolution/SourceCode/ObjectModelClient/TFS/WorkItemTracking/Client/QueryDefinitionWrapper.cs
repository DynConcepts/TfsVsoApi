using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class QueryDefinitionWrapper : QueryDefinitionWrapper<IQueryDefinition, QueryDefinition>, IQueryDefinition
    {
        protected QueryDefinitionWrapper(QueryDefinition instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryDefinition, QueryDefinition>(src => src == null ? null : ((QueryDefinitionWrapper) src).r_Instance, src => new QueryDefinitionWrapper(src)); }
    }


    internal class QueryDefinitionWrapper<TWrapper, TInterface> : QueryItemWrapper<TWrapper, TInterface>, IQueryDefinition where TInterface : class where TWrapper : class
    {
        String IQueryDefinition.QueryText
        {
            get
            {
                string nativeCallResult = r_Instance.QueryText;
                return nativeCallResult;
            }
            set { r_Instance.QueryText = value; }
        }

        IQueryType IQueryDefinition.QueryType
        {
            get
            {
                QueryType nativeCallResult = r_Instance.QueryType;
                IQueryType wrappedCallResult = QueryTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected QueryDefinitionWrapper(QueryDefinition instance) : base(instance) { r_Instance = instance; }
        protected new readonly QueryDefinition r_Instance;
    }
}