using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldFilterWrapper.
    /// </summary>
    internal class FieldFilterWrapper : FieldFilterWrapper<IFieldFilter, FieldFilter>, IFieldFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldFilterWrapper(FieldFilter instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldFilter, FieldFilter>(src => src == null ? null : ((FieldFilterWrapper) src).r_Instance, src => new FieldFilterWrapper(src)); }
    }


    /// <summary>
    /// Class FieldFilterWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class FieldFilterWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IFieldFilter where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the field definition.
        /// </summary>
        /// <value>The field definition.</value>
        IFieldDefinition IFieldFilter.FieldDefinition
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance.FieldDefinition;
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        Object IFieldFilter.Value
        {
            get
            {
                object nativeCallResult = r_Instance.Value;
                return nativeCallResult;
            }
            set { r_Instance.Value = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FieldFilterWrapper(FieldFilter instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly FieldFilter r_Instance;
    }
}