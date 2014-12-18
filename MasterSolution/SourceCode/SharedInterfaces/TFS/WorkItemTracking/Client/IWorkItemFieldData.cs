using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemFieldData : IIWorkItemOpenFieldDataHelper ,IIWorkItemSaveFieldDataHelper
  {
    Boolean SetUpdateFieldValue( Int32 id, Object value, IWorkItemFieldData_FieldFlags flags);
    IWorkItemFieldData_FieldInfo GetFieldState( Int32 id);
    new Boolean IsDirty();
    Boolean GetUpdateFieldValue( Int32 id,out IWorkItemFieldData_FieldUpdate fu);
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
    Boolean IsEmpty();
  }
}
namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemFieldData_FieldUpdate
  {
  }
}
