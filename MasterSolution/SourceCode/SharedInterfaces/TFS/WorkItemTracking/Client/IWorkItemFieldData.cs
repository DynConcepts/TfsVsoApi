using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemFieldData : IIWorkItemOpenFieldDataHelper, IIWorkItemSaveFieldDataHelper
    {
        IWorkItemFieldData_FieldInfo GetFieldState(Int32 id);
        Boolean GetUpdateFieldValue(Int32 id, out IWorkItemFieldData_FieldUpdate fu);
        new Boolean IsDirty();
        Boolean SetUpdateFieldValue(Int32 id, Object value, IWorkItemFieldData_FieldFlags flags);
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public enum IWorkItemFieldData_FieldFlags
    {
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