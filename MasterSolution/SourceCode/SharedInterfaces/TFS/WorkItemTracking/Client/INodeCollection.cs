using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface INodeCollection : IReadOnlyList
    {
        Boolean Contains(INode value);
        Int32 IndexOf(INode value);
        INode this[Int32 index] { get; }
        INode this[String name] { get; }
    }
}