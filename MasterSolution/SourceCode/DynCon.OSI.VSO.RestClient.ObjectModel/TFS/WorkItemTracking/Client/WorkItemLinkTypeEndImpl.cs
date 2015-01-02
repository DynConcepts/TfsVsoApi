using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemLinkTypeEndImpl.
    /// </summary>
    internal class WorkItemLinkTypeEndImpl : JsonLinkTypeEnd, IWorkItemLinkTypeEnd
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>WorkItemLinkTypeEndImpl.</returns>
        public static WorkItemLinkTypeEndImpl FromToken(JToken token)
        {
            var instance = new WorkItemLinkTypeEndImpl(token);
            return instance;
        }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException">
        ///     API does nbot support Id property
        ///     for LinkTypeEnd
        /// </exception>
        Int32 IWorkItemLinkTypeEnd.Id { get { throw new NoReStAPIEquivilantException("API does nbot support Id property for LinkTypeEnd"); } }

        /// <summary>
        ///     Gets the name of the immutable.
        /// </summary>
        /// <value>The name of the immutable.</value>
        String IWorkItemLinkTypeEnd.ImmutableName { get { return ImmutableName; } }

        /// <summary>
        ///     Gets the is forward link.
        /// </summary>
        /// <value>The is forward link.</value>
        Boolean IWorkItemLinkTypeEnd.IsForwardLink { get { return ImmutableName.Contains("Forward"); } }

        /// <summary>
        ///     Gets the type of the link.
        /// </summary>
        /// <value>The type of the link.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkType IWorkItemLinkTypeEnd.LinkType { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
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

        /// <summary>
        ///     Gets the opposite end.
        /// </summary>
        /// <value>The opposite end.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkTypeEnd IWorkItemLinkTypeEnd.OppositeEnd { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemLinkTypeEndImpl" /> class.
        /// </summary>
        /// <param name="jsonValue">The json value.</param>
        public WorkItemLinkTypeEndImpl(JToken jsonValue) : base(jsonValue) { }
    }
}