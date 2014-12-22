using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemLinkCollection : IVariableSizeList
    {
        Int32 Add(IWorkItemLink link);
        Boolean Contains(IWorkItemLink link);
        Int32 IndexOf(IWorkItemLink link);
        void Refresh();
        void Remove(IWorkItemLink link);
        IEnumerable<IWorkItemLink> AddedLinks { get; }
        IEnumerable<IWorkItemLink> DeletedLinks { get; }
        IWorkItemLink this[Int32 index] { get; }
    }
}