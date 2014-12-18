using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class WorkItemIdWrapper : WorkItemIdWrapper<IWorkItemId, WorkItemId>, IWorkItemId
    {
        protected WorkItemIdWrapper(WorkItemId instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemId, WorkItemId>(src => src==null ? null : ((WorkItemIdWrapper) src).r_Instance, src => new WorkItemIdWrapper(src)); }
    }


    internal class WorkItemIdWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemId where TInterface : class where TWrapper : class
    {
        Int32 IWorkItemId.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
            set { r_Instance.Id = value; }
        }

        Int64 IWorkItemId.RowVersion
        {
            get
            {
                long nativeCallResult = r_Instance.RowVersion;
                return nativeCallResult;
            }
            set { r_Instance.RowVersion = value; }
        }

        void IWorkItemId.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected WorkItemIdWrapper(WorkItemId instance) { r_Instance = instance; }
        protected readonly WorkItemId r_Instance;
    }
}