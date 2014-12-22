using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IHyperlink : ILink
    {
        String Location { get; }
    }
}