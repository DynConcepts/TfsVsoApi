using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class AccessControlEntryImpl : IAccessControlEntry
    {
        Int32 IAccessControlEntry.Allow { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IAccessControlEntry.Deny { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IIdentityDescriptor IAccessControlEntry.Descriptor { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IAceExtendedInformation IAccessControlEntry.ExtendedInfo { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean IAccessControlEntry.IsEmpty { get { throw new ToBeImplementedException(); } }
    }
}