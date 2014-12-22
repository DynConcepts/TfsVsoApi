using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    public class IterationImpl : JsonIteration, IIteration
    {
        protected IterationImpl(JToken content)
            : base(content)
        {
        }


        public static IterationImpl FromToken(JObject content)
        {
            var instance = new IterationImpl(content);
            return instance;
        }

        public new IList<IIteration> Children { get { throw new NotImplementedException(); } }

        public new IIteration Parent { get { throw new NotImplementedException(); } }
    }
}