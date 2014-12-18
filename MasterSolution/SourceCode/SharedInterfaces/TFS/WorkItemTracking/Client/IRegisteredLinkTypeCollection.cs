namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IRegisteredLinkTypeCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList
  {
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType value);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType value);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType this[System.Int32 index] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType this[DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType registeredType] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType this[System.String name] { get;   }
  }
}
