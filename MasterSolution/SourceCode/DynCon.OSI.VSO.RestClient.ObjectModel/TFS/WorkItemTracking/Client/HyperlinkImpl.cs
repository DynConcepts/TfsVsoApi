using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class HyperlinkImpl.
    /// </summary>
    internal class HyperlinkImpl : LinkImpl, IHyperlink
    {
        /// <summary>
        ///     Gets the location.
        /// </summary>
        /// <value>The location.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IHyperlink.Location { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="HyperlinkImpl" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public HyperlinkImpl(JToken json) : base(json) { }
    }
}