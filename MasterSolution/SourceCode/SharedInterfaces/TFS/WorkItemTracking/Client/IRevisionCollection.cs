using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IRevisionCollection : IReadOnlyList
    {
        Boolean Contains(IRevision value);
        Int32 IndexOf(IRevision value);
        IRevision this[Int32 index] { get; }
    }
}