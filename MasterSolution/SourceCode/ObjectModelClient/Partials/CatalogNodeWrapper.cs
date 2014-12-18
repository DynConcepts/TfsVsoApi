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


        public static IEnumerable<KeyValuePair<string, IList<ICatalogNode>>> GetWrapper(IEnumerable<KeyValuePair<string, IList<CatalogNode>>> nativeCallResult) { throw new NotImplementedException(); }
    }
}