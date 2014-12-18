using System;
using System.Diagnostics;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels
{
    internal class TfsRequestSettingsImpl : ITfsRequestSettings
    {
        String ITfsRequestSettings.AgentId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean ITfsRequestSettings.BypassProxyOnLocal { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        ITfsRequestSettings ITfsRequestSettings.Clone() { throw new ToBeImplementedException(); }
        Boolean ITfsRequestSettings.CompressRequestBody { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean ITfsRequestSettings.CompressionEnabled { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 ITfsRequestSettings.ConnectionLimit { get { throw new ToBeImplementedException(); } }
        TimeSpan ITfsRequestSettings.SendTimeout { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean ITfsRequestSettings.SoapTraceEnabled { get { throw new ToBeImplementedException(); } }
        TraceSwitch ITfsRequestSettings.Tracing { get { throw new ToBeImplementedException(); } }
        String ITfsRequestSettings.UserAgent { get { throw new ToBeImplementedException(); } }
    }
}