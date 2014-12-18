using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class RegisteredLinkTypeCollectionImpl : ReadOnlyListImpl<IRegisteredLinkType>, IRegisteredLinkTypeCollection
    {
        protected RegisteredLinkTypeCollectionImpl(IReadOnlyList<IRegisteredLinkType> items)
            : base(items)
        {
        }

        Boolean IRegisteredLinkTypeCollection.Contains(IRegisteredLinkType value) {return Items.Contains(value); }
        Int32 IRegisteredLinkTypeCollection.IndexOf(IRegisteredLinkType value) { return Items.IndexOf(value);}
        IRegisteredLinkType IRegisteredLinkTypeCollection.this[Int32 index] { get { return Items[index]; } }
        IRegisteredLinkType IRegisteredLinkTypeCollection.this[IRegisteredLinkType registeredType] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IRegisteredLinkType IRegisteredLinkTypeCollection.this[String name] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}