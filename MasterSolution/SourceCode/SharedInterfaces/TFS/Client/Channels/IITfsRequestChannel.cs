namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface IITfsRequestChannel
  {
    void Abort();
    System.IAsyncResult BeginRequest( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message, System.AsyncCallback callback, System.Object state);
    System.IAsyncResult BeginRequest( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message, System.TimeSpan timeout, System.AsyncCallback callback, System.Object state);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage EndRequest( System.IAsyncResult result);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage Request( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage Request( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessage message, System.TimeSpan timeout);
    System.Uri Uri  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials Credentials  { get;   }
    System.Globalization.CultureInfo Culture  { get;   }
    System.Guid SessionId  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings Settings  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsHttpClientState State  { get;   }
  }
}
