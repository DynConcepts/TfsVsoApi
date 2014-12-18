using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class SortFieldWrapper : SortFieldWrapper<ISortField, SortField>, ISortField
    {
        protected SortFieldWrapper(SortField instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ISortField, SortField>(src => ((SortFieldWrapper) src).r_Instance, src => new SortFieldWrapper(src)); }
    }


    internal class SortFieldWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ISortField where TInterface : class where TWrapper : class
    {
        IFieldDefinition ISortField.FieldDefinition
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance.FieldDefinition;
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ISortType ISortField.SortType
        {
            get
            {
                SortType nativeCallResult = r_Instance.SortType;
                ISortType wrappedCallResult = SortTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected SortFieldWrapper(SortField instance) { r_Instance = instance; }
        protected readonly SortField r_Instance;
    }
}