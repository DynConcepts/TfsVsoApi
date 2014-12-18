using DynCon.OSI.VSO.ObjectModelClient.Base;

namespace DynCon.OSI.VSO.ObjectModelClient.WorkItemTracking.Client
{
  internal partial class IRevisionInternalWrapper : IRevisionInternalWrapper<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal, Microsoft.TeamFoundation.WorkItemTracking.Client.IRevisionInternal> , DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal
{
     protected IRevisionInternalWrapper(Microsoft.TeamFoundation.WorkItemTracking.Client.IRevisionInternal instance) : base(instance){}
    internal static void SetMapper() { Mapper = new ObjectMapper<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal, Microsoft.TeamFoundation.WorkItemTracking.Client.IRevisionInternal>(src => ((IRevisionInternalWrapper) src).r_Instance, src => new IRevisionInternalWrapper(src));}
}


  internal abstract  partial class IRevisionInternalWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface> , DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal where TInterface : class where  TWrapper : class
  {
     protected readonly Microsoft.TeamFoundation.WorkItemTracking.Client.IRevisionInternal r_Instance;
     protected IRevisionInternalWrapper(Microsoft.TeamFoundation.WorkItemTracking.Client.IRevisionInternal instance)
     { r_Instance = instance; }
// Is Bsse Method: False
    void DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal.SetFieldValue( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd,  System.Object value)
    {
      r_Instance.SetFieldValue(DynCon.OSI.VSO.ObjectModelClient.WorkItemTracking.Client.FieldDefinitionWrapper.GetInstance(fd), value);
    }
// Is Bsse Method: False
    System.Object DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal.GetCurrentFieldValue( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd)
    {
      var nativeCallResult = r_Instance.GetCurrentFieldValue(DynCon.OSI.VSO.ObjectModelClient.WorkItemTracking.Client.FieldDefinitionWrapper.GetInstance(fd));
    return nativeCallResult;
    }
// Is Bsse Method: False
    System.Object DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal.GetOriginalFieldValue( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd)
    {
      var nativeCallResult = r_Instance.GetOriginalFieldValue(DynCon.OSI.VSO.ObjectModelClient.WorkItemTracking.Client.FieldDefinitionWrapper.GetInstance(fd));
    return nativeCallResult;
    }
// Is Bsse Method: False
    System.Object DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal.GetCurrentFieldValueWithServerDefault( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd)
    {
      var nativeCallResult = r_Instance.GetCurrentFieldValueWithServerDefault(DynCon.OSI.VSO.ObjectModelClient.WorkItemTracking.Client.FieldDefinitionWrapper.GetInstance(fd));
    return nativeCallResult;
    }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal.WorkItem 
    {
      get { 
          var nativeCallResult = r_Instance.WorkItem;
          var wrappedCallResult = DynCon.OSI.VSO.ObjectModelClient.WorkItemTracking.Client.WorkItemWrapper.GetWrapper(nativeCallResult); 
          return wrappedCallResult;
          }
    }
    System.Boolean DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal.IsReadOnly 
    {
      get { 
          var nativeCallResult = r_Instance.IsReadOnly;
          return nativeCallResult;
          }
    }
    System.Int32 DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IIRevisionInternal.Number 
    {
      get { 
          var nativeCallResult = r_Instance.Number;
          return nativeCallResult;
          }
    }
  }
}
