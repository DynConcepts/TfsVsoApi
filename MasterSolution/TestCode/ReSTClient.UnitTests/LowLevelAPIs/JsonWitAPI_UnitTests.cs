using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    public partial class JsonWitAPI_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Builds the work item_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="workItemTypeName">Name of the work item type.</param>
        /// <param name="fieldValues">The field values.</param>
        partial void BuildWorkItem_PreCondition(JsonWitAPI instance, ref String projectName, ref String workItemTypeName, ref IReadOnlyList<KeyValuePair<String, Object>> fieldValues)
        {
            projectName = "RestPlaypen";
            workItemTypeName = "Task";
            var dictionary = new List<KeyValuePair<String, Object>>
            {
                new KeyValuePair<string, object>("System.Title", "Sample Title"),
            };
            fieldValues = dictionary;
        }

        /// <summary>
        ///     Creates the work item_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="workItemType">Type of the work item.</param>
        /// <param name="workItem">The work item.</param>
        /// <param name="inPlaceUpdate">The in place update.</param>
        partial void CreateWorkItem_PreCondition(JsonWitAPI instance, ref String project, ref String workItemType, ref JsonWorkItem workItem, ref Boolean inPlaceUpdate)
        {
            project = "RestPlaypen";
            workItemType = "Task";
            var fieldValues = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("System.Title", "WorkItem Created by Unit Testing")
            };
            workItem = JsonWitAPI.BuildWorkItem(project, workItemType, fieldValues);
            inPlaceUpdate = true;
        }

        /// <summary>
        ///     Gets the areas_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        partial void GetAreas_PreCondition(JsonWitAPI instance, ref String project, ref Int32 depth)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the child queries_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="parent">The parent.</param>
        partial void GetChildQueries_PreCondition(JsonWitAPI instance, ref String project, ref JsonQueryFolder parent)
        {
            project = "RestPlaypen";
            var choices = instance.GetQueries(project).Result;
            foreach (var choice in choices)
            {
                var asFolder = choice as JsonQueryFolder;
                if (asFolder != null)
                {
                    parent = asFolder;
                    return;
                }
            }
            throw new Exception("Could not Find Folder to use as Parent");
        }

        /// <summary>
        ///     Gets the iterations_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        partial void GetIterations_PreCondition(JsonWitAPI instance, ref String project, ref Int32 depth)
        {
            project = "RestPlaypen";
        }

        partial void GetLinksForWorkItem_PreCondition(JsonWitAPI instance, ref JsonWorkItem workItem)
        {
            workItem = JsonWorkItem_UnitTests.GetInstance();
        }

        /// <summary>
        ///     Gets the queries_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetQueries_PreCondition(JsonWitAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the work item type categories_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetWorkItemTypeCategories_PreCondition(JsonWitAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the work item types_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetWorkItemTypes_PreCondition(JsonWitAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the work item_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="uri">The URI.</param>
        partial void GetWorkItem_PreCondition(JsonWitAPI instance, ref Uri uri)
        {
            uri = new Uri("https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/217");
        }

        /// <summary>
        ///     Gets the work items_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="ids">The ids.</param>
        partial void GetWorkItems_PreCondition(JsonWitAPI instance, ref IEnumerable<Int32> ids)
        {
            ids = new List<int> {1, 2, 3};
        }

        /// <summary>
        ///     Updates the work item_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="workItem">The work item.</param>
        partial void UpdateWorkItem_PreCondition(JsonWitAPI instance, ref JsonWorkItem workItem)
        {
            var workItems = instance.GetWorkItems(new List<int> { 2 }).Result;
            workItem = workItems[0];
        }

        partial void WiqlQuery_PreCondition(JsonWitAPI instance, ref String wiql, ref Boolean fullyPopulate)
        {
            wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        /// <summary>
        ///     The SR_ disabled tests
        /// </summary>
        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetWorkItem_UnitTest"
        };
    }
}