namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface IIWorkItemOpenFieldDataHelper
  {
    void SetLatestData( System.Collections.Generic.Dictionary<System.Int32,System.Object> latestData);
    void SetRevisionData( System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.Int32,System.Object>> revisionData);
    System.Int32 GetFieldId( System.String fieldName);
    System.Boolean HasField( System.Int32 fieldId);
  }
}
