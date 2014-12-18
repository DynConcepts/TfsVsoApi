using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal class WorkItemLinkInfoWrapper : WorkItemLinkInfoWrapper<IWorkItemLinkInfo, WorkItemLinkInfo>, IWorkItemLinkInfo
    {
        protected WorkItemLinkInfoWrapper(WorkItemLinkInfo instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLinkInfo, WorkItemLinkInfo>(src => ((WorkItemLinkInfoWrapper) src).r_Instance, src => new WorkItemLinkInfoWrapper(src)); }
    }


    internal class WorkItemLinkInfoWrapper<TWrapper, TInterface> : LinkInfoWrapper<TWrapper, TInterface>, IWorkItemLinkInfo where TInterface : class where TWrapper : class
    {
        Boolean IWorkItemLinkInfo.IsLocked
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLocked;
                return nativeCallResult;
            }
            set { r_Instance.IsLocked = value; }
        }

        Int32 IWorkItemLinkInfo.LinkType
        {
            get
            {
                int nativeCallResult = r_Instance.LinkType;
                return nativeCallResult;
            }
            set { r_Instance.LinkType = value; }
        }

        Int32 IWorkItemLinkInfo.SourceId
        {
            get
            {
                int nativeCallResult = r_Instance.SourceId;
                return nativeCallResult;
            }
            set { r_Instance.SourceId = value; }
        }

        Int32 IWorkItemLinkInfo.TargetId
        {
            get
            {
                int nativeCallResult = r_Instance.TargetId;
                return nativeCallResult;
            }
            set { r_Instance.TargetId = value; }
        }

        protected WorkItemLinkInfoWrapper(WorkItemLinkInfo instance) : base(instance) { r_Instance = instance; }
        protected new readonly WorkItemLinkInfo r_Instance;
    }
}