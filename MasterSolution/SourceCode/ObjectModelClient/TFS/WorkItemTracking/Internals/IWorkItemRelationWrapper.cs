using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemRelationWrapper : IWorkItemRelationWrapper<IIWorkItemRelation, IWorkItemRelation>, IIWorkItemRelation
    {
        protected IWorkItemRelationWrapper(IWorkItemRelation instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIWorkItemRelation, IWorkItemRelation>(src => src == null ? null : ((IWorkItemRelationWrapper) src).r_Instance, src => new IWorkItemRelationWrapper(src)); }
    }


    internal abstract class IWorkItemRelationWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIWorkItemRelation where TInterface : class where TWrapper : class
    {
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

        protected IWorkItemRelationWrapper(IWorkItemRelation instance) { r_Instance = instance; }
        protected readonly IWorkItemRelation r_Instance;
    }
}