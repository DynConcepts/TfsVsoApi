using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface ICategory
    {
        Boolean Contains(IWorkItemType value);
        IWorkItemType DefaultWorkItemType { get; }
        String Name { get; }
        String ReferenceName { get; }
        IEnumerable<IWorkItemType> WorkItemTypes { get; }
    }
}