using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface ITFProxyServer
    {
        void NotifyUnavailable();
        Boolean IsAvailable { get; }
        Boolean IsEnabled { get; set; }
        DateTime LastConfigureTime { get; set; }
        String Url { get; set; }
        Boolean WasAutoConfigured { get; set; }
    }
}