using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class QueryWrapper_UnitTests
    {
        static partial void InstanceFactory(ref QueryWrapper instance, string callerName)
        {
            if ((callerName == "RunLinkQuery_UnitTest") || (callerName == "EndLinkQuery_UnitTest"))
            {
                WorkItemStore store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
                const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItemLinks WHERE ([Source].[System.TeamProject] = 'RestPlaypen'  AND  [Source].[System.WorkItemType] <> ''  AND  [Source].[System.State] <> '') And ([System.Links.LinkType] = 'System.LinkTypes.Hierarchy-Forward') And ([Target].[System.WorkItemType] <> '') ORDER BY [System.Id] mode(Recursive)";
                var real = new Query(store, wiql);
                instance = (QueryWrapper) QueryWrapper.GetWrapper(real);
            }
        }

        partial void EndLinkQuery_PreCondition(IQuery instance, ref IICancelableAsyncResult car) { car = instance.BeginLinkQuery(); }

        partial void EndCountOnlyQuery_PreCondition(IQuery instance, ref IICancelableAsyncResult car) { car = instance.BeginCountOnlyQuery(); }
        partial void EndQuery_PreCondition(IQuery instance, ref IICancelableAsyncResult car) { car = instance.BeginQuery(); }

        partial void EndRegularQuery_PreCondition(IQuery instance, ref IICancelableAsyncResult car) { car = instance.BeginRegularQuery(); }

        partial void GetLinkTypes_PreCondition(IQuery instance) { instance = GetInstance(); }

        static partial void RealInstanceFactory(ref Query real, string callerName)
        {
            WorkItemStore store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            real = new Query(store, wiql);
        }

    
        partial void BeginCountOnlyQuery_PreCondition(IQuery instance)
        {
            ExpectEvent("AsyncStateChanged{Microsoft.TeamFoundation.WorkItemTracking.Client.Query}");
        }

        partial void BeginLinkQuery_PreCondition(IQuery instance)
        {
            ExpectEvent("AsyncStateChanged{Microsoft.TeamFoundation.WorkItemTracking.Client.Query}");
        }
        partial void BeginQuery_PreCondition(IQuery instance)
        {
            ExpectEvent("AsyncStateChanged{Microsoft.TeamFoundation.WorkItemTracking.Client.Query}");
        }
        partial void BeginRegularQuery_PreCondition(IQuery instance)
        {
            ExpectEvent("AsyncStateChanged{Microsoft.TeamFoundation.WorkItemTracking.Client.Query}");
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

       
    }
}