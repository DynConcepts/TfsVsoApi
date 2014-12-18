namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IRegisteredLinkType
  {
    System.Boolean Equals( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType type);
    System.String Name  { get;   }
  }
}
