using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IStoredQueryCollection : IVariableSizeList
    {
        Int32 Add(IStoredQuery storedQuery);
        Int32 IndexOf(IStoredQuery storedQuery);
        void Refresh();
        void Remove(IStoredQuery storedQuery);
        IStoredQuery this[Guid guid] { get; }
        IStoredQuery this[Int32 index] { get; }
    }
}