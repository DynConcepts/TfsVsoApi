using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal struct WorkItemRelationWrapper : IWorkItemRelation
    {
        public static WorkItemRelation GetInstance(IWorkItemRelation src) { return default(WorkItemRelation); }
        public static WorkItemRelation[] GetInstance(IWorkItemRelation[] src) { return null; }
        public static WorkItemRelationWrapper GetWrapper(WorkItemRelation src) { return default(WorkItemRelationWrapper); }
        public static IWorkItemRelation[] GetWrapper(WorkItemRelation[] src) { return null; }

        Boolean IIWorkItemRelation.IsLocked
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLocked;
                return nativeCallResult;
            }
            set { r_Instance.IsLocked = value; }
        }

        Int32 IIWorkItemRelation.LinkTypeID
        {
            get
            {
                int nativeCallResult = r_Instance.LinkTypeID;
                return nativeCallResult;
            }
            set { r_Instance.LinkTypeID = value; }
        }

        Int32 IIWorkItemRelation.SourceID
        {
            get
            {
                int nativeCallResult = r_Instance.SourceID;
                return nativeCallResult;
            }
            set { r_Instance.SourceID = value; }
        }

        Int32 IIWorkItemRelation.TargetID
        {
            get
            {
                int nativeCallResult = r_Instance.TargetID;
                return nativeCallResult;
            }
            set { r_Instance.TargetID = value; }
        }

        private WorkItemRelationWrapper(WorkItemRelation instance) { r_Instance = instance; }
        private WorkItemRelation r_Instance;
    }
}