using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemLinkType
    {
        void Activate();
        void Deactivate();
        void Delete();
        XmlDocument Export();
        Boolean CanDelete { get; }
        Boolean CanEdit { get; }
        IWorkItemLinkTypeEnd ForwardEnd { get; }
        Boolean IsActive { get; }
        Boolean IsDeleted { get; }
        Boolean IsDirectional { get; }
        Boolean IsNonCircular { get; }
        Boolean IsOneToMany { get; }
        IWorkItemLinkType_Topology LinkTopology { get; }
        String ReferenceName { get; }
        IWorkItemLinkTypeEnd ReverseEnd { get; }
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public enum IWorkItemLinkType_Topology
    {
    }
}