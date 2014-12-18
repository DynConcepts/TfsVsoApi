using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IProject
  {
    INode FindNodeInSubTree( Int32 nodeId);
    INode FindNodeInSubTree( String path, INode_TreeType treeType);
    IWorkItemTypeCollection WorkItemTypes  { get;   }
    ICategoryCollection Categories  { get;   }
    IWorkItemStore Store  { get;   }
    INodeCollection AreaRootNodes  { get;   }
    Uri AreaRootNodeUri  { get;   }
    INodeCollection IterationRootNodes  { get;   }
    Int32 Id  { get;   }
    String Name  { get;   }
    Uri Uri  { get;   }
    String Guid  { get;   }
    IStoredQueryCollection StoredQueries  { get;   }
    IQueryHierarchy QueryHierarchy  { get;   }
    Boolean HasWorkItemReadRights  { get;   }
    Boolean HasWorkItemWriteRights  { get;   }
    Boolean HasWorkItemReadRightsRecursive  { get;   }
    Boolean HasWorkItemWriteRightsRecursive  { get;   }
  }
}
