using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IRegisteredLinkType
    {
        Boolean Equals(IRegisteredLinkType type);
        String Name { get; }
    }
}