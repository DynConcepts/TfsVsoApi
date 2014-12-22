using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemRelationImpl : IIWorkItemRelation
    {
        Boolean IIWorkItemRelation.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IIWorkItemRelation.LinkTypeID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IIWorkItemRelation.SourceID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IIWorkItemRelation.TargetID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}