using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IStoredQuery : IComparable
    {
        Int32 CompareTo(IStoredQuery storedQuery);
        void Reset();
        void Update();
        DateTime CreationTime { get; }
        DateTime CreationTimeUtc { get; }
        String Description { get; set; }
        Boolean IsSaved { get; }
        DateTime LastWriteTime { get; }
        DateTime LastWriteTimeUtc { get; }
        String Name { get; set; }
        String Owner { get; }
        IProject Project { get; }
        Guid QueryGuid { get; }
        IQueryScope QueryScope { get; set; }
        String QueryText { get; set; }
    }
}