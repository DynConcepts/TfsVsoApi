namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface INode : System.Collections.IEnumerable
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INode FindNodeInSubTree( System.Int32 nodeId);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INode FindNodeInSubTree( System.String path);
    System.Int32 Id  { get;   }
    System.String Name  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INode ParentNode  { get;   }
    System.Boolean HasChildNodes  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INodeCollection ChildNodes  { get;   }
    System.Uri Uri  { get;   }
    System.String Path  { get;   }
    System.Boolean IsIterationNode  { get;   }
    System.Boolean IsAreaNode  { get;   }
    System.Boolean HasWorkItemReadRights  { get;   }
    System.Boolean HasWorkItemWriteRights  { get;   }
    System.Boolean HasWorkItemReadRightsRecursive  { get;   }
    System.Boolean HasWorkItemWriteRightsRecursive  { get;   }
  }
}
namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public enum INode_TreeType  {
  }
}
