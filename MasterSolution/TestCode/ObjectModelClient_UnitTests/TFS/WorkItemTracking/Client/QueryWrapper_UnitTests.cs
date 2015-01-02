using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class QueryWrapper_UnitTests
    {
        partial void GetLinkTypes_PreCondition(ref IQuery instance) { instance = GetInstance(); }

        static partial void RealInstanceFactory(ref Query real, string callerName)
        {
            WorkItemStore store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            real = new Query(store, wiql);
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "RunRevisionQuery_UnitTest"
        };

        partial void RunLinkQuery_PreCondition(ref IQuery instance)
        {
            WorkItemStore store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            const string wiql = "select * from WorkItemLinks where ([Source].[System.WorkItemType] = ‘Feature’ and [Source].[System.State] = ‘Active’) and ([System.Links.LinkType] = ‘System.LinkTypes.Dependency-Forward’) and (([Target].[System.WorkItemType = ‘Bug’ and [Target].[System.AssignedTo] = @me) order by [System.Id] mode(mustcontain)";
            var real = new Query(store, wiql);
            instance = (QueryWrapper) QueryWrapper.GetWrapper(real);

        }

    }
}