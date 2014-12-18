namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemFieldData : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper ,DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper
  {
    System.Boolean SetUpdateFieldValue( System.Int32 id, System.Object value, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags flags);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldInfo GetFieldState( System.Int32 id);
    new System.Boolean IsDirty();
    System.Boolean GetUpdateFieldValue( System.Int32 id,out DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldUpdate fu);
  }
}
namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public enum IWorkItemFieldData_FieldFlags  {
  }
}
namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemFieldData_FieldInfo
  {
    System.Boolean IsEmpty();
  }
}
namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemFieldData_FieldUpdate
  {
  }
}
