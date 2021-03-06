﻿using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

// ReSharper disable once CheckNamespace

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal partial class LinkUpdateWrapper
    {
        public static IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> GetWrapper(IEnumerable<KeyValuePair<LinkInfo, LinkUpdate>> nativeCallResult) { throw new NotImplementedException(); }

        internal static Dictionary<ILinkInfo, ILinkUpdate> GetWrapper(Dictionary<LinkInfo, LinkUpdate> src)
        {
            if (src == null)
                return null;
            var retVal = new Dictionary<ILinkInfo, ILinkUpdate>();
            foreach (var pair in src)
            {
                var key = LinkInfoWrapper.GetWrapper(pair.Key);
                var value = GetWrapper(pair.Value);
                retVal.Add(key, value);
            }
            return retVal;
        }
    }
}