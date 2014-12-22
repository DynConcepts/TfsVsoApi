using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemCollection : IReadOnlyList
    {
        Boolean Contains(IWorkItem value);
        Int32 GetId(Int32 index);
        Int32 IndexOf(Int32 id);
        Int32 IndexOf(IWorkItem value);
        void Resort();
        DateTime AsOf { get; set; }
        DateTime AsOfUTC { get; set; }
        Int32 DefaultProjectHint { get; set; }
        IDisplayFieldList DisplayFields { get; }
        IWorkItem this[Int32 index] { get; }
        Int32 PageSize { get; set; }
        IQuery Query { get; }
        ISortFieldList SortFields { get; }
        IWorkItemStore Store { get; }
    }
}