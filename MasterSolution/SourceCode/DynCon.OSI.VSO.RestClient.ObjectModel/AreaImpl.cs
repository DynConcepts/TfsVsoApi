using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel
{
    /// <summary>
    /// Class AreaImpl.
    /// </summary>
    public class AreaImpl : JsonArea, IArea
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonArea" /> class.
        /// </summary>
        /// <param name="content">The content.</param>
        protected AreaImpl(JToken content)
            : base(content)
        {
        }

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>AreaImpl.</returns>
        public static AreaImpl FromToken(JObject content)
        {
            var instance = new AreaImpl(content);
            return instance;
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public new IList<IArea> Children { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public new IArea Parent { get { throw new NotImplementedException(); } }
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public string Links { get { throw new NotImplementedException(); } }
    }
}