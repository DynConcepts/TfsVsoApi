using DynCon.OSI.VSO.ObjectModelClient.Base;

namespace DynCon.OSI.VSO.ObjectModelClient.WorkItemTracking.Client
{
  internal partial class IFieldStoreWrapper : IFieldStoreWrapper<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore, Microsoft.TeamFoundation.WorkItemTracking.Client.IFieldStore> , DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore
{
     protected IFieldStoreWrapper(Microsoft.TeamFoundation.WorkItemTracking.Client.IFieldStore instance) : base(instance){}
    internal static void SetMapper() { Mapper = new ObjectMapper<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore, Microsoft.TeamFoundation.WorkItemTracking.Client.IFieldStore>(src => ((IFieldStoreWrapper) src).r_Instance, src => new IFieldStoreWrapper(src));}
}


  internal abstract  partial class IFieldStoreWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface> , DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore where TInterface : class where  TWrapper : class
  {
     protected readonly Microsoft.TeamFoundation.WorkItemTracking.Client.IFieldStore r_Instance;
     protected IFieldStoreWrapper(Microsoft.TeamFoundation.WorkItemTracking.Client.IFieldStore instance)
     { r_Instance = instance; }
// Is Bsse Method: False
    System.Boolean DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore.HasValue( System.Int32 row,  System.Int32 fieldId)
    {
      var nativeCallResult = r_Instance.HasValue(row, fieldId);
    return nativeCallResult;
    }
// Is Bsse Method: False
    void DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore.StoreValue( System.Int32 row,  System.Int32 fieldId,  System.Object value)
    {
      r_Instance.StoreValue(row, fieldId, value);
    }
// Is Bsse Method: False
    System.Object DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore.GetStoredValue( System.Int32 row,  System.Int32 fieldId)
    {
      var nativeCallResult = r_Instance.GetStoredValue(row, fieldId);
    return nativeCallResult;
    }
// Is Bsse Method: False
    void DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore.SetAccessDenied( System.Int32 row)
    {
      r_Instance.SetAccessDenied(row);
    }
// Is Bsse Method: False
    System.Boolean DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIFieldStore.IsAccessDenied( System.Int32 row)
    {
      var nativeCallResult = r_Instance.IsAccessDenied(row);
    return nativeCallResult;
    }
  }
}
