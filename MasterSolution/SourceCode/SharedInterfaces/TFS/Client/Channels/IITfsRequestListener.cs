namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface IITfsRequestListener
  {
    void AfterReceiveReply( System.Int64 requestId, System.String methodName, System.Net.HttpWebResponse response);
    void BeforeSendRequest( System.Int64 requestId, System.String methodName, System.Net.HttpWebRequest request);
    System.Int64 BeginRequest();
    void EndRequest( System.Int64 requestId, System.Exception exception);
  }
}
