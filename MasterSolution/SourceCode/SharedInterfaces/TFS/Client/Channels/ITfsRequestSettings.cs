namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface ITfsRequestSettings
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsRequestSettings Clone();
    System.Boolean BypassProxyOnLocal  { get; set;   }
    System.Boolean CompressionEnabled  { get; set;   }
    System.Boolean CompressRequestBody  { get; set;   }
    System.Int32 ConnectionLimit  { get;   }
    System.TimeSpan SendTimeout  { get; set;   }
    System.Boolean SoapTraceEnabled  { get;   }
    System.Diagnostics.TraceSwitch Tracing  { get;   }
    System.String UserAgent  { get;   }
    System.String AgentId  { get; set;   }
  }
}
