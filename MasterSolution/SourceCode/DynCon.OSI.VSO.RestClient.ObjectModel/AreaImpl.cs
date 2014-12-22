using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    public class AreaImpl : JsonArea, IArea
    {
        protected AreaImpl(JToken content)
            : base(content)
        {
        }

        public static AreaImpl FromToken(JObject content)
        {
            var instance = new AreaImpl(content);
            return instance;
        }

        public new IList<IArea> Children { get { throw new NotImplementedException(); } }

        public new IArea Parent { get { throw new NotImplementedException(); } }
        public string Links { get { throw new NotImplementedException(); } }
    }
}