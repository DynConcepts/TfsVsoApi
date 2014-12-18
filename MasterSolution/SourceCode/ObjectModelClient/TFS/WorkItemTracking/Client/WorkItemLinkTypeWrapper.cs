using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeWrapper : WorkItemLinkTypeWrapper<IWorkItemLinkType, WorkItemLinkType>, IWorkItemLinkType
    {
        protected WorkItemLinkTypeWrapper(WorkItemLinkType instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLinkType, WorkItemLinkType>(src => ((WorkItemLinkTypeWrapper) src).r_Instance, src => new WorkItemLinkTypeWrapper(src)); }
    }


    internal class WorkItemLinkTypeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemLinkType where TInterface : class where TWrapper : class
    {

        void IWorkItemLinkType.Activate() { r_Instance.Activate(); }

        Boolean IWorkItemLinkType.CanDelete
        {
            get
            {
                bool nativeCallResult = r_Instance.CanDelete;
                return nativeCallResult;
            }
        }

        Boolean IWorkItemLinkType.CanEdit
        {
            get
            {
                bool nativeCallResult = r_Instance.CanEdit;
                return nativeCallResult;
            }
        }


        void IWorkItemLinkType.Deactivate() { r_Instance.Deactivate(); }
        void IWorkItemLinkType.Delete() { r_Instance.Delete(); }

        XmlDocument IWorkItemLinkType.Export()
        {
            XmlDocument nativeCallResult = r_Instance.Export();
            return nativeCallResult;
        }

        IWorkItemLinkTypeEnd IWorkItemLinkType.ForwardEnd
        {
            get
            {
                WorkItemLinkTypeEnd nativeCallResult = r_Instance.ForwardEnd;
                IWorkItemLinkTypeEnd wrappedCallResult = WorkItemLinkTypeEndWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IWorkItemLinkType.IsActive
        {
            get
            {
                bool nativeCallResult = r_Instance.IsActive;
                return nativeCallResult;
            }
        }

        Boolean IWorkItemLinkType.IsDeleted
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDeleted;
                return nativeCallResult;
            }
        }

        Boolean IWorkItemLinkType.IsDirectional
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDirectional;
                return nativeCallResult;
            }
        }

        Boolean IWorkItemLinkType.IsNonCircular
        {
            get
            {
                bool nativeCallResult = r_Instance.IsNonCircular;
                return nativeCallResult;
            }
        }

        Boolean IWorkItemLinkType.IsOneToMany
        {
            get
            {
                bool nativeCallResult = r_Instance.IsOneToMany;
                return nativeCallResult;
            }
        }

        IWorkItemLinkType_Topology IWorkItemLinkType.LinkTopology
        {
            get
            {
                WorkItemLinkType.Topology nativeCallResult = r_Instance.LinkTopology;
                IWorkItemLinkType_Topology wrappedCallResult = WorkItemLinkType_TopologyWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IWorkItemLinkType.ReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReferenceName;
                return nativeCallResult;
            }
        }

        IWorkItemLinkTypeEnd IWorkItemLinkType.ReverseEnd
        {
            get
            {
                WorkItemLinkTypeEnd nativeCallResult = r_Instance.ReverseEnd;
                IWorkItemLinkTypeEnd wrappedCallResult = WorkItemLinkTypeEndWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemLinkTypeWrapper(WorkItemLinkType instance) { r_Instance = instance; }
        protected readonly WorkItemLinkType r_Instance;
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class WorkItemLinkType_TopologyWrapper
    {
        public static WorkItemLinkType.Topology GetInstance(IWorkItemLinkType_Topology src) { return default(WorkItemLinkType.Topology); }

        public static WorkItemLinkType.Topology[] GetInstance(IWorkItemLinkType_Topology[] src) { return null; }
        public static IWorkItemLinkType_Topology GetWrapper(WorkItemLinkType.Topology src) { return default(IWorkItemLinkType_Topology); }
        public static IWorkItemLinkType_Topology[] GetWrapper(WorkItemLinkType.Topology[] src) { return null; }
    }
}