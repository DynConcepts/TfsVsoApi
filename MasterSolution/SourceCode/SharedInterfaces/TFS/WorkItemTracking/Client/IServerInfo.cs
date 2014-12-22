using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IServerInfo
    {
        Boolean IsSupported(String feature);
        IEnumerable<String> Features { get; }
    }
}