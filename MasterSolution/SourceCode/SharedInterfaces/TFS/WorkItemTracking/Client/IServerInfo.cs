namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IServerInfo
  {
    System.Boolean IsSupported( System.String feature);
    System.Collections.Generic.IEnumerable<System.String> Features  { get;   }
  }
}
