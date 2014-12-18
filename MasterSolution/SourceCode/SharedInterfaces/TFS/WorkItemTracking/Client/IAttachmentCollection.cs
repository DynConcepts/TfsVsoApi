namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IAttachmentCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList
  {
    void Refresh();
    System.Int32 Add( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachment attachment);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachment attachment);
    void Remove( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachment attachment);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachment attachment);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachment this[System.Int32 index] { get;   }
  }
}
