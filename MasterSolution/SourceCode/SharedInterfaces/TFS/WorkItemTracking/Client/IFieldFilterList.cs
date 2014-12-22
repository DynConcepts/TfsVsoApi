using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IFieldFilterList : IVariableSizeList
    {
        Int32 Add(IFieldFilter filter);
        Boolean Contains(IFieldFilter value);
        Int32 IndexOf(IFieldFilter filter);
        Int32 IndexOfFieldId(Int32 id);
        void Remove(IFieldFilter value);
        IFieldFilter this[Int32 index] { get; }
    }
}