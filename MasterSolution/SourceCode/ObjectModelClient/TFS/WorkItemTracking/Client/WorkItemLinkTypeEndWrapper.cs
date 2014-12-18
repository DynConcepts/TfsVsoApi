using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeEndWrapper : WorkItemLinkTypeEndWrapper<IWorkItemLinkTypeEnd, WorkItemLinkTypeEnd>, IWorkItemLinkTypeEnd
    {
        protected WorkItemLinkTypeEndWrapper(WorkItemLinkTypeEnd instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLinkTypeEnd, WorkItemLinkTypeEnd>(src => ((WorkItemLinkTypeEndWrapper) src).r_Instance, src => new WorkItemLinkTypeEndWrapper(src)); }
    }


    internal class WorkItemLinkTypeEndWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemLinkTypeEnd where TInterface : class where TWrapper : class
    {
        Int32 IWorkItemLinkTypeEnd.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        String IWorkItemLinkTypeEnd.ImmutableName
        {
            get
            {
                string nativeCallResult = r_Instance.ImmutableName;
                return nativeCallResult;
            }
        }

        Boolean IWorkItemLinkTypeEnd.IsForwardLink
        {
            get
            {
                bool nativeCallResult = r_Instance.IsForwardLink;
                return nativeCallResult;
            }
        }

        IWorkItemLinkType IWorkItemLinkTypeEnd.LinkType
        {
            get
            {
                WorkItemLinkType nativeCallResult = r_Instance.LinkType;
                IWorkItemLinkType wrappedCallResult = WorkItemLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IWorkItemLinkTypeEnd.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        IWorkItemLinkTypeEnd IWorkItemLinkTypeEnd.OppositeEnd
        {
            get
            {
                WorkItemLinkTypeEnd nativeCallResult = r_Instance.OppositeEnd;
                IWorkItemLinkTypeEnd wrappedCallResult = WorkItemLinkTypeEndWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemLinkTypeEndWrapper(WorkItemLinkTypeEnd instance) { r_Instance = instance; }
        protected readonly WorkItemLinkTypeEnd r_Instance;
    }
}