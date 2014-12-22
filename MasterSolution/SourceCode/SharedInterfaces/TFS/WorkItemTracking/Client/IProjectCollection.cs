using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IProjectCollection : IReadOnlyList
    {
        Boolean Contains(String projectName);
        Boolean Contains(IProject value);
        IProject GetById(Int32 projectId);
        Int32 IndexOf(IProject value);
        IProject this[Int32 index] { get; }
        IProject this[String projectName] { get; }
    }
}