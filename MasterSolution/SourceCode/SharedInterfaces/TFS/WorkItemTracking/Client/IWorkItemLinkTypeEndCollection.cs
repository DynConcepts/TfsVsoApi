using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemLinkTypeEndCollection : IEnumerable
    {
        Boolean Contains(Int32 id);
        Boolean Contains(String linkTypeName);
        IWorkItemLinkTypeEnd GetById(Int32 id);
        Boolean TryGetById(Int32 id, out IWorkItemLinkTypeEnd linkTypeEnd);
        Boolean TryGetByName(String linkTypeEndName, out IWorkItemLinkTypeEnd linkTypeEnd);
        Int32 Count { get; }
        IWorkItemLinkTypeEnd this[String linkTypeEndName] { get; }
    }
}