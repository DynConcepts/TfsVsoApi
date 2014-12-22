using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IAttachment
    {
        DateTime AttachedTime { get; }
        DateTime AttachedTimeUtc { get; }
        String Comment { get; set; }
        DateTime CreationTime { get; }
        DateTime CreationTimeUtc { get; }
        String Extension { get; }
        String FileGuid { get; }
        Int32 Id { get; }
        Boolean IsSaved { get; }
        DateTime LastWriteTime { get; }
        DateTime LastWriteTimeUtc { get; }
        Int64 Length { get; }
        String Name { get; }
        Uri Uri { get; }
    }
}