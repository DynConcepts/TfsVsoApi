using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal struct WorkItemRelationImpl : IWorkItemRelation
    {
        Boolean IIWorkItemRelation.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IIWorkItemRelation.LinkTypeID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IIWorkItemRelation.SourceID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IIWorkItemRelation.TargetID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}