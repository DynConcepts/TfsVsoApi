using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class DisplayFieldListWrapper : DisplayFieldListWrapper<IDisplayFieldList, DisplayFieldList>, IDisplayFieldList
    {
        protected DisplayFieldListWrapper(DisplayFieldList instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IDisplayFieldList, DisplayFieldList>(src => ((DisplayFieldListWrapper) src).r_Instance, src => new DisplayFieldListWrapper(src)); }
    }


    internal class DisplayFieldListWrapper<TWrapper, TInterface> : OrderedVariableSizeListWrapper<TWrapper, TInterface>, IDisplayFieldList where TInterface : class where TWrapper : class
    {

        Int32 IDisplayFieldList.Add(IFieldDefinition value)
        {
            int nativeCallResult = r_Instance.Add(FieldDefinitionWrapper.GetInstance(value));
            return nativeCallResult;
        }



        Int32 IDisplayFieldList.Add(String fieldName)
        {
            int nativeCallResult = r_Instance.Add(fieldName);
            return nativeCallResult;
        }

        Boolean IDisplayFieldList.Contains(IFieldDefinition value)
        {
            bool nativeCallResult = r_Instance.Contains(FieldDefinitionWrapper.GetInstance(value));
            return nativeCallResult;
        }

        Int32 IDisplayFieldList.IndexOf(IFieldDefinition value)
        {
            int nativeCallResult = r_Instance.IndexOf(FieldDefinitionWrapper.GetInstance(value));
            return nativeCallResult;
        }

        Int32 IDisplayFieldList.IndexOfFieldId(Int32 id)
        {
            int nativeCallResult = r_Instance.IndexOfFieldId(id);
            return nativeCallResult;
        }

        void IDisplayFieldList.Insert(Int32 index, IFieldDefinition value) { r_Instance.Insert(index, FieldDefinitionWrapper.GetInstance(value)); }


        void IDisplayFieldList.Insert(Int32 index, String fieldName) { r_Instance.Insert(index, fieldName); }

        IFieldDefinition IDisplayFieldList.this[Int32 index]
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance[index];
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                FieldDefinition nativeValue = FieldDefinitionWrapper.GetInstance(value);
                r_Instance[index] = nativeValue;
            }
        }

        void IDisplayFieldList.Remove(String fieldName) { r_Instance.Remove(fieldName); }
        void IDisplayFieldList.Remove(IFieldDefinition value) { r_Instance.Remove(FieldDefinitionWrapper.GetInstance(value)); }
        protected DisplayFieldListWrapper(DisplayFieldList instance) : base(instance) { r_Instance = instance; }
        protected new readonly DisplayFieldList r_Instance;
    }
}