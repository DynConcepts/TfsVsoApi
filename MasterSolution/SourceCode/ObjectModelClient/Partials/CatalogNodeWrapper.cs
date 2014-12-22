using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

// ReSharper disable once CheckNamespace

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal partial class CatalogNodeWrapper
    {
        public static IEnumerable<KeyValuePair<string, ICatalogNode>> GetWrapper(IEnumerable<KeyValuePair<string, CatalogNode>> nativeCallResult) { throw new NotImplementedException(); }


        public static IEnumerable<KeyValuePair<string, IList<ICatalogNode>>> GetWrapper(IEnumerable<KeyValuePair<string, IList<CatalogNode>>> src)
        {
            var retVal = new List<KeyValuePair<string, IList<ICatalogNode>>>();
            foreach (KeyValuePair<string, IList<CatalogNode>> pair in src)
            {
                IList<ICatalogNode> list = new List<ICatalogNode>();
                foreach (CatalogNode entry in pair.Value)
                    list.Add(GetWrapper(entry));
                var item = new KeyValuePair<string, IList<ICatalogNode>>(pair.Key, list);
                retVal.Add(item);
            }
            return retVal;
        }
    }
}