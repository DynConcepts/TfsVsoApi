namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IArtifactWorkItemIds : DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsXmlSerializable
  {
    System.Int32[] GetWorkItemIds();
    System.Int32 UriListOffset  { get; set;   }
    System.String Uri  { get;   }
  }
}
