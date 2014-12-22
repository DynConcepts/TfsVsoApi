using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common
{
    internal class IVersionTagImpl : IIVersionTag
    {
        Int32 IIVersionTag.VersionTag { get { throw new ToBeImplementedException(); } }
    }
}