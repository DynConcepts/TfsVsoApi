using DynCon.OSI.VSO.ObjectModelClient.Base;

namespace DynCon.OSI.VSO.ObjectModelClient.WorkItemTracking.Proxy
{
  internal partial class ISerializeRowWrapper : ISerializeRowWrapper<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IISerializeRow, Microsoft.TeamFoundation.WorkItemTracking.Proxy.ISerializeRow> , DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IISerializeRow
{
     protected ISerializeRowWrapper(Microsoft.TeamFoundation.WorkItemTracking.Proxy.ISerializeRow instance) : base(instance){}
    internal static void SetMapper() { Mapper = new ObjectMapper<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IISerializeRow, Microsoft.TeamFoundation.WorkItemTracking.Proxy.ISerializeRow>(src => ((ISerializeRowWrapper) src).r_Instance, src => new ISerializeRowWrapper(src));}
}


  internal abstract  partial class ISerializeRowWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface> , DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IISerializeRow where TInterface : class where  TWrapper : class
  {
     protected readonly Microsoft.TeamFoundation.WorkItemTracking.Proxy.ISerializeRow r_Instance;
     protected ISerializeRowWrapper(Microsoft.TeamFoundation.WorkItemTracking.Proxy.ISerializeRow instance)
     { r_Instance = instance; }
// Is Bsse Method: False
    void DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IISerializeRow.CopyRow( System.Int32 row,  System.IntPtr p,  System.Int32 esz)
    {
      r_Instance.CopyRow(row, p, esz);
    }
  }
}
