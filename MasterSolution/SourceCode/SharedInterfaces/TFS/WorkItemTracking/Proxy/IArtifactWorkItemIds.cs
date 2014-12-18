using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IArtifactWorkItemIds : IITfsXmlSerializable
  {
    Int32[] GetWorkItemIds();
    Int32 UriListOffset  { get; set;   }
    String Uri  { get;   }
  }
}
