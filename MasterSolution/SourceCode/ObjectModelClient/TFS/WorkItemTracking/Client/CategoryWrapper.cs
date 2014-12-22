using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class CategoryWrapper : CategoryWrapper<ICategory, Category>, ICategory
    {
        protected CategoryWrapper(Category instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICategory, Category>(src => src == null ? null : ((CategoryWrapper) src).r_Instance, src => new CategoryWrapper(src)); }
    }


    internal class CategoryWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICategory where TInterface : class where TWrapper : class
    {
        Boolean ICategory.Contains(IWorkItemType value)
        {
            bool nativeCallResult = r_Instance.Contains(WorkItemTypeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        IWorkItemType ICategory.DefaultWorkItemType
        {
            get
            {
                WorkItemType nativeCallResult = r_Instance.DefaultWorkItemType;
                IWorkItemType wrappedCallResult = WorkItemTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String ICategory.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        String ICategory.ReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReferenceName;
                return nativeCallResult;
            }
        }

        IEnumerable<IWorkItemType> ICategory.WorkItemTypes
        {
            get
            {
                IEnumerable<WorkItemType> nativeCallResult = r_Instance.WorkItemTypes;
                IEnumerable<IWorkItemType> wrappedCallResult = WorkItemTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected CategoryWrapper(Category instance) { r_Instance = instance; }
        protected readonly Category r_Instance;
    }
}