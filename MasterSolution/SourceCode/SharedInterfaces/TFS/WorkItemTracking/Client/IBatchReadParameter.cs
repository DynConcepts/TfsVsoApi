using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IBatchReadParameter
    {
        Int32 Id { get; }
        Int32 ProjectHint { get; set; }
        Int32 Revision { get; }
    }
}