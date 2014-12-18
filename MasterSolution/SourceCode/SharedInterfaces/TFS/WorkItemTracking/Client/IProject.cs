namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IProject
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INode FindNodeInSubTree( System.Int32 nodeId);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INode FindNodeInSubTree( System.String path, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INode_TreeType treeType);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemTypeCollection WorkItemTypes  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ICategoryCollection Categories  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore Store  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INodeCollection AreaRootNodes  { get;   }
    System.Uri AreaRootNodeUri  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INodeCollection IterationRootNodes  { get;   }
    System.Int32 Id  { get;   }
    System.String Name  { get;   }
    System.Uri Uri  { get;   }
    System.String Guid  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQueryCollection StoredQueries  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy QueryHierarchy  { get;   }
    System.Boolean HasWorkItemReadRights  { get;   }
    System.Boolean HasWorkItemWriteRights  { get;   }
    System.Boolean HasWorkItemReadRightsRecursive  { get;   }
    System.Boolean HasWorkItemWriteRightsRecursive  { get;   }
  }
}
