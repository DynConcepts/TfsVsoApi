using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class FieldFilterWrapper : FieldFilterWrapper<IFieldFilter, FieldFilter>, IFieldFilter
    {
        protected FieldFilterWrapper(FieldFilter instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldFilter, FieldFilter>(src => ((FieldFilterWrapper) src).r_Instance, src => new FieldFilterWrapper(src)); }
    }


    internal class FieldFilterWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IFieldFilter where TInterface : class where TWrapper : class
    {
        IFieldDefinition IFieldFilter.FieldDefinition
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance.FieldDefinition;
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Object IFieldFilter.Value
        {
            get
            {
                object nativeCallResult = r_Instance.Value;
                return nativeCallResult;
            }
            set { r_Instance.Value = value; }
        }

        protected FieldFilterWrapper(FieldFilter instance) { r_Instance = instance; }
        protected readonly FieldFilter r_Instance;
    }
}