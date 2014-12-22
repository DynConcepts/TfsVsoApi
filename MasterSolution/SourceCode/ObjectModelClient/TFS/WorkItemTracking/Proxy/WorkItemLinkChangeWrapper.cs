using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class WorkItemLinkChangeWrapper : WorkItemLinkChangeWrapper<IWorkItemLinkChange, WorkItemLinkChange>, IWorkItemLinkChange
    {
        protected WorkItemLinkChangeWrapper(WorkItemLinkChange instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLinkChange, WorkItemLinkChange>(src => src == null ? null : ((WorkItemLinkChangeWrapper) src).r_Instance, src => new WorkItemLinkChangeWrapper(src)); }
    }


    internal class WorkItemLinkChangeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemLinkChange where TInterface : class where TWrapper : class
    {
        DateTime IWorkItemLinkChange.ChangedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.ChangedDate;
                return nativeCallResult;
            }
            set { r_Instance.ChangedDate = value; }
        }

        Boolean IWorkItemLinkChange.IsActive
        {
            get
            {
                bool nativeCallResult = r_Instance.IsActive;
                return nativeCallResult;
            }
            set { r_Instance.IsActive = value; }
        }

        String IWorkItemLinkChange.LinkType
        {
            get
            {
                string nativeCallResult = r_Instance.LinkType;
                return nativeCallResult;
            }
            set { r_Instance.LinkType = value; }
        }

        Int64 IWorkItemLinkChange.RowVersion
        {
            get
            {
                long nativeCallResult = r_Instance.RowVersion;
                return nativeCallResult;
            }
            set { r_Instance.RowVersion = value; }
        }

        Int32 IWorkItemLinkChange.SourceID
        {
            get
            {
                int nativeCallResult = r_Instance.SourceID;
                return nativeCallResult;
            }
            set { r_Instance.SourceID = value; }
        }

        Int32 IWorkItemLinkChange.TargetID
        {
            get
            {
                int nativeCallResult = r_Instance.TargetID;
                return nativeCallResult;
            }
            set { r_Instance.TargetID = value; }
        }

        void IWorkItemLinkChange.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected WorkItemLinkChangeWrapper(WorkItemLinkChange instance) { r_Instance = instance; }
        protected readonly WorkItemLinkChange r_Instance;
    }
}