using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ICategory
  {
    Boolean Contains( IWorkItemType value);
    String ReferenceName  { get;   }
    String Name  { get;   }
    IWorkItemType DefaultWorkItemType  { get;   }
    IEnumerable<IWorkItemType> WorkItemTypes  { get;   }
  }
}
