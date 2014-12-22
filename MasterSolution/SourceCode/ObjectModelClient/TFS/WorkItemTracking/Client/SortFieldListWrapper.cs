using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class SortFieldListWrapper : SortFieldListWrapper<ISortFieldList, SortFieldList>, ISortFieldList
    {
        protected SortFieldListWrapper(SortFieldList instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ISortFieldList, SortFieldList>(src => src == null ? null : ((SortFieldListWrapper) src).r_Instance, src => new SortFieldListWrapper(src)); }
    }


    internal class SortFieldListWrapper<TWrapper, TInterface> : OrderedVariableSizeListWrapper<TWrapper, TInterface>, ISortFieldList where TInterface : class where TWrapper : class
    {
        Int32 ISortFieldList.Add(ISortField sortField)
        {
            int nativeCallResult = r_Instance.Add(SortFieldWrapper.GetInstance(sortField));
            return nativeCallResult;
        }


        Int32 ISortFieldList.Add(String name, ISortType sortType)
        {
            int nativeCallResult = r_Instance.Add(name, SortTypeWrapper.GetInstance(sortType));
            return nativeCallResult;
        }

        Boolean ISortFieldList.Contains(ISortField value)
        {
            bool nativeCallResult = r_Instance.Contains(SortFieldWrapper.GetInstance(value));
            return nativeCallResult;
        }

        Int32 ISortFieldList.IndexOf(ISortField sortField)
        {
            int nativeCallResult = r_Instance.IndexOf(SortFieldWrapper.GetInstance(sortField));
            return nativeCallResult;
        }

        Int32 ISortFieldList.IndexOfFieldId(Int32 id)
        {
            int nativeCallResult = r_Instance.IndexOfFieldId(id);
            return nativeCallResult;
        }


        void ISortFieldList.Insert(Int32 index, ISortField sortField) { r_Instance.Insert(index, SortFieldWrapper.GetInstance(sortField)); }

        void ISortFieldList.Insert(Int32 index, String name, ISortType sortType) { r_Instance.Insert(index, name, SortTypeWrapper.GetInstance(sortType)); }

        ISortField ISortFieldList.this[Int32 index]
        {
            get
            {
                SortField nativeCallResult = r_Instance[index];
                ISortField wrappedCallResult = SortFieldWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                SortField nativeValue = SortFieldWrapper.GetInstance(value);
                r_Instance[index] = nativeValue;
            }
        }


        void ISortFieldList.Remove(String fieldName) { r_Instance.Remove(fieldName); }

        void ISortFieldList.Remove(IFieldDefinition fd) { r_Instance.Remove(FieldDefinitionWrapper.GetInstance(fd)); }


        void ISortFieldList.Remove(ISortField value) { r_Instance.Remove(SortFieldWrapper.GetInstance(value)); }
        protected SortFieldListWrapper(SortFieldList instance) : base(instance) { r_Instance = instance; }
        protected new readonly SortFieldList r_Instance;
    }
}