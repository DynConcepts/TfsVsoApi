using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkWrapper : WorkItemLinkWrapper<IWorkItemLink, WorkItemLink>, IWorkItemLink
    {
        protected WorkItemLinkWrapper(WorkItemLink instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLink, WorkItemLink>(src => src == null ? null : ((WorkItemLinkWrapper) src).r_Instance, src => new WorkItemLinkWrapper(src)); }
    }


    internal class WorkItemLinkWrapper<TWrapper, TInterface> : LinkWrapper<TWrapper, TInterface>, IWorkItemLink where TInterface : class where TWrapper : class
    {
        String IWorkItemLink.AddedBy
        {
            get
            {
                string nativeCallResult = r_Instance.AddedBy;
                return nativeCallResult;
            }
        }

        DateTime IWorkItemLink.AddedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AddedDate;
                return nativeCallResult;
            }
        }

        DateTime IWorkItemLink.AddedDateUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AddedDateUtc;
                return nativeCallResult;
            }
        }

        DateTime? IWorkItemLink.ChangedDate
        {
            get
            {
                DateTime? nativeCallResult = r_Instance.ChangedDate;
                return nativeCallResult;
            }
            set { r_Instance.ChangedDate = value; }
        }

        IWorkItemLinkTypeEnd IWorkItemLink.LinkTypeEnd
        {
            get
            {
                WorkItemLinkTypeEnd nativeCallResult = r_Instance.LinkTypeEnd;
                IWorkItemLinkTypeEnd wrappedCallResult = WorkItemLinkTypeEndWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IWorkItemLink.RemovedBy
        {
            get
            {
                string nativeCallResult = r_Instance.RemovedBy;
                return nativeCallResult;
            }
        }

        DateTime IWorkItemLink.RemovedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.RemovedDate;
                return nativeCallResult;
            }
        }

        DateTime IWorkItemLink.RemovedDateUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.RemovedDateUtc;
                return nativeCallResult;
            }
        }

        Int32 IWorkItemLink.SourceId
        {
            get
            {
                int nativeCallResult = r_Instance.SourceId;
                return nativeCallResult;
            }
            set { r_Instance.SourceId = value; }
        }

        Int32 IWorkItemLink.TargetId
        {
            get
            {
                int nativeCallResult = r_Instance.TargetId;
                return nativeCallResult;
            }
            set { r_Instance.TargetId = value; }
        }

        protected WorkItemLinkWrapper(WorkItemLink instance) : base(instance) { r_Instance = instance; }
        protected new readonly WorkItemLink r_Instance;
    }
}