using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IQueryFolder : IQueryItem, IEnumerable
    {
        void Add(IQueryItem item);
        Boolean Contains(String name);
        Boolean Contains(IQueryItem item);
        Boolean Contains(Guid id);
        Int32 Count { get; }
        Boolean IsRootNode { get; }
        IQueryItem this[Guid id] { get; }
        IQueryItem this[String name] { get; }
    }
}