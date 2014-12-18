using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface INode : IEnumerable
  {
    INode FindNodeInSubTree( Int32 nodeId);
    INode FindNodeInSubTree( String path);
    Int32 Id  { get;   }
    String Name  { get;   }
    INode ParentNode  { get;   }
    Boolean HasChildNodes  { get;   }
    INodeCollection ChildNodes  { get;   }
    Uri Uri  { get;   }
    String Path  { get;   }
    Boolean IsIterationNode  { get;   }
    Boolean IsAreaNode  { get;   }
    Boolean HasWorkItemReadRights  { get;   }
    Boolean HasWorkItemWriteRights  { get;   }
    Boolean HasWorkItemReadRightsRecursive  { get;   }
    Boolean HasWorkItemWriteRightsRecursive  { get;   }
  }
}
namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public enum INode_TreeType  {
  }
}
