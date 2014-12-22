using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeEndImpl : JsonLinkTypeEnd, IWorkItemLinkTypeEnd
    {

        public static WorkItemLinkTypeEndImpl FromToken(JToken token)
        {
            var instance = new WorkItemLinkTypeEndImpl(token);
            return instance;
        }

        public WorkItemLinkTypeEndImpl(JToken jsonValue) : base(jsonValue) { }
        Int32 IWorkItemLinkTypeEnd.Id { get { throw new NoReStAPIEquivilantException("API does nbot support Id property for LinkTypeEnd"); } }
        String IWorkItemLinkTypeEnd.ImmutableName { get { return ImmutableName; } }
        Boolean IWorkItemLinkTypeEnd.IsForwardLink { get { return ImmutableName.Contains("Forward"); } }
        IWorkItemLinkType IWorkItemLinkTypeEnd.LinkType { get { throw new ToBeImplementedException(); } }

        String IWorkItemLinkTypeEnd.Name
        {
            get
            {
                switch (ImmutableName)
                {
                    case "System.LinkTypes.Hierarchy-Forward":
                        return "Parent";
                    case "System.LinkTypes.Hierarchy-Reverse":
                        return "Child";
                    case "Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Forward":
                        return "Referenced By";
                    default:
                        return ImmutableName;
                }
            }
        }

        IWorkItemLinkTypeEnd IWorkItemLinkTypeEnd.OppositeEnd { get { throw new ToBeImplementedException(); } }
    }
}