using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel
{
    /// <summary>
    /// Class IterationImpl.
    /// </summary>
    public class IterationImpl : JsonIteration, IIteration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonIteration" /> class.
        /// </summary>
        /// <param name="content">The content.</param>
        protected IterationImpl(JToken content)
            : base(content)
        {
        }


        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>IterationImpl.</returns>
        public static IterationImpl FromToken(JObject content)
        {
            var instance = new IterationImpl(content);
            return instance;
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public new IList<IIteration> Children { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public new IIteration Parent { get { throw new NotImplementedException(); } }
    }
}