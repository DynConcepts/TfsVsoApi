using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class ExternalLinkImpl.
    /// </summary>
    internal class ExternalLinkImpl : LinkImpl, IExternalLink
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>ILinkImpl.</returns>
        public new static ILinkImpl FromToken(JToken content) { return LinkImpl.FromToken(content); }


        /// <summary>
        ///     Gets the linked artifact URI.
        /// </summary>
        /// <value>The linked artifact URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IExternalLink.LinkedArtifactUri { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ExternalLinkImpl" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public ExternalLinkImpl(JToken json) : base(json) { }
    }
}