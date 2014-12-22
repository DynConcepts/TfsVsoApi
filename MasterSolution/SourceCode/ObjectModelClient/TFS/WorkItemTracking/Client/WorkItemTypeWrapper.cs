using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemTypeWrapper : WorkItemTypeWrapper<IWorkItemType, WorkItemType>, IWorkItemType
    {
        protected WorkItemTypeWrapper(WorkItemType instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemType, WorkItemType>(src => src == null ? null : ((WorkItemTypeWrapper) src).r_Instance, src => new WorkItemTypeWrapper(src)); }
    }


    internal class WorkItemTypeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemType where TInterface : class where TWrapper : class
    {
        String IWorkItemType.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
        }

        String IWorkItemType.DisplayForm
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayForm;
                return nativeCallResult;
            }
        }

        XmlDocument IWorkItemType.Export(Boolean includeGlobalListsFlag)
        {
            XmlDocument nativeCallResult = r_Instance.Export(includeGlobalListsFlag);
            return nativeCallResult;
        }

        IFieldDefinitionCollection IWorkItemType.FieldDefinitions
        {
            get
            {
                FieldDefinitionCollection nativeCallResult = r_Instance.FieldDefinitions;
                IFieldDefinitionCollection wrappedCallResult = FieldDefinitionCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        String IWorkItemType.GetNextState(String currentState, String action)
        {
            string nativeCallResult = r_Instance.GetNextState(currentState, action);
            return nativeCallResult;
        }


        String IWorkItemType.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        IWorkItem IWorkItemType.NewWorkItem()
        {
            WorkItem nativeCallResult = r_Instance.NewWorkItem();
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IProject IWorkItemType.Project
        {
            get
            {
                Project nativeCallResult = r_Instance.Project;
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItemStore IWorkItemType.Store
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.Store;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemTypeWrapper(WorkItemType instance) { r_Instance = instance; }
        protected readonly WorkItemType r_Instance;
    }
}