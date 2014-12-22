using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface ILinkCollection : IVariableSizeList
    {
        Int32 Add(ILink link);
        Int32 Add(IHyperlink link);
        Int32 Add(IExternalLink link);
        Int32 Add(IRelatedLink link);
        Boolean Contains(ILink link);
        Int32 IndexOf(ILink link);
        void Refresh();
        void Remove(ILink link);
        ILink this[Int32 index] { get; }
        IWorkItem WorkItem { get; }
    }
}