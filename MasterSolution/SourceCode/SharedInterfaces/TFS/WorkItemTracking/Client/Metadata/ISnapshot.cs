using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata
{
    public interface ISnapshot
    {
        Dictionary<Int32, Int32> LoadFieldIdsByWorkItemType(Int32 typeId);
        IWorkItemStore Store { get; }
    }
}