using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IRegisteredLinkTypeCollection : IReadOnlyList
    {
        Boolean Contains(IRegisteredLinkType value);
        Int32 IndexOf(IRegisteredLinkType value);
        IRegisteredLinkType this[Int32 index] { get; }
        IRegisteredLinkType this[IRegisteredLinkType registeredType] { get; }
        IRegisteredLinkType this[String name] { get; }
    }
}