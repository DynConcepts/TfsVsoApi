namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IValuesCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList
  {
    System.Boolean Contains( System.String value);
    System.Int32 IndexOf( System.String value);
    System.String this[System.Int32 index] { get;   }
  }
}
