using System;
using System.Globalization;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface IITfsRequestChannel
  {
    void Abort();
    IAsyncResult BeginRequest( ITfsMessage message, AsyncCallback callback, Object state);
    IAsyncResult BeginRequest( ITfsMessage message, TimeSpan timeout, AsyncCallback callback, Object state);
    ITfsMessage EndRequest( IAsyncResult result);
    ITfsMessage Request( ITfsMessage message);
    ITfsMessage Request( ITfsMessage message, TimeSpan timeout);
    Uri Uri  { get;   }
    ITfsClientCredentials Credentials  { get;   }
    CultureInfo Culture  { get;   }
    Guid SessionId  { get;   }
    ITfsRequestSettings Settings  { get;   }
    ITfsHttpClientState State  { get;   }
  }
}
