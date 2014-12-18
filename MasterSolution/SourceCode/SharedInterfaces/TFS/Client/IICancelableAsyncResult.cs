namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IICancelableAsyncResult : System.IAsyncResult
  {
    void Cancel();
    System.Boolean IsCanceled  { get;   }
  }
}
