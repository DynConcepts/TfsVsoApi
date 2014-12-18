using System;
using System.Diagnostics;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels
{
    internal class TfsRequestSettingsImpl : ITfsRequestSettings
    {
        String ITfsRequestSettings.AgentId { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ITfsRequestSettings.BypassProxyOnLocal { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ITfsRequestSettings ITfsRequestSettings.Clone() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean ITfsRequestSettings.CompressRequestBody { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ITfsRequestSettings.CompressionEnabled { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 ITfsRequestSettings.ConnectionLimit { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        TimeSpan ITfsRequestSettings.SendTimeout { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ITfsRequestSettings.SoapTraceEnabled { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        TraceSwitch ITfsRequestSettings.Tracing { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ITfsRequestSettings.UserAgent { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}