using System;
using System.Diagnostics;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface ITfsRequestSettings
  {
    ITfsRequestSettings Clone();
    Boolean BypassProxyOnLocal  { get; set;   }
    Boolean CompressionEnabled  { get; set;   }
    Boolean CompressRequestBody  { get; set;   }
    Int32 ConnectionLimit  { get;   }
    TimeSpan SendTimeout  { get; set;   }
    Boolean SoapTraceEnabled  { get;   }
    TraceSwitch Tracing  { get;   }
    String UserAgent  { get;   }
    String AgentId  { get; set;   }
  }
}
