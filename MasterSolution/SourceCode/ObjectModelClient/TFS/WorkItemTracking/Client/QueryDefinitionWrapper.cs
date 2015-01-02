using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class QueryDefinitionWrapper.
    /// </summary>
    internal class QueryDefinitionWrapper : QueryDefinitionWrapper<IQueryDefinition, QueryDefinition>, IQueryDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDefinitionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryDefinitionWrapper(QueryDefinition instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryDefinition, QueryDefinition>(src => src == null ? null : ((QueryDefinitionWrapper) src).r_Instance, src => new QueryDefinitionWrapper(src)); }
    }


    /// <summary>
    /// Class QueryDefinitionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class QueryDefinitionWrapper<TWrapper, TInterface> : QueryItemWrapper<TWrapper, TInterface>, IQueryDefinition where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the query text.
        /// </summary>
        /// <value>The query text.</value>
        String IQueryDefinition.QueryText
        {
            get
            {
                string nativeCallResult = r_Instance.QueryText;
                return nativeCallResult;
            }
            set { r_Instance.QueryText = value; }
        }

        /// <summary>
        /// Gets the type of the query.
        /// </summary>
        /// <value>The type of the query.</value>
        IQueryType IQueryDefinition.QueryType
        {
            get
            {
                QueryType nativeCallResult = r_Instance.QueryType;
                IQueryType wrappedCallResult = QueryTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDefinitionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryDefinitionWrapper(QueryDefinition instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly QueryDefinition r_Instance;
    }
}