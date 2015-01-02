using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class TFProxyServerImpl.
    /// </summary>
    internal class TFProxyServerImpl : ITFProxyServer
    {
        /// <summary>
        ///     Gets the is available.
        /// </summary>
        /// <value>The is available.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ITFProxyServer.IsAvailable { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the is enabled.
        /// </summary>
        /// <value>The is enabled.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean ITFProxyServer.IsEnabled { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the last configure time.
        /// </summary>
        /// <value>The last configure time.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        DateTime ITFProxyServer.LastConfigureTime { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Notifies the unavailable.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITFProxyServer.NotifyUnavailable() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String ITFProxyServer.Url { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the was automatic configured.
        /// </summary>
        /// <value>The was automatic configured.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean ITFProxyServer.WasAutoConfigured { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}