using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class WitRestCalls.
    /// </summary>
    internal class WitRestCalls
    {
        /*
/wit/attachments		POST		_apis/wit/attachments?fileName=imageAsFileAttachment.png&api-version=1.0
/wit/$batch		POST		_apis/wit/$batch?api-version=1.0
/wit/workItemTypeCategories		GET		{project}/_apis/wit/workItemTypeCategories?api-version=1.0
/wit/workItemTypeCategories/{categoryName}		GET		{project}/_apis/wit/workItemTypeCategories/Microsoft.RequirementCategory?api-version=1.0
/wit/classificationNodes/areas		GET		{project}/_apis/wit/classificationNodes/areas?api-version=1.0
/wit/classificationNodes/areas/{areaPath}		GET		{project}/_apis/wit/classificationNodes/areas/Website?api-version=1.0
/wit/classificationNodes/iterations		GET		{project}/_apis/wit/classificationNodes/iterations?api-version=1.0
/wit/classificationNodes/iterations/{iterationPath}		GET		{project}/_apis/wit/classificationNodes/iterations/Release%201/Sprint%202?api-version=1.0
/wit/fields		GET		_apis/wit/fields?api-version=1.0
/wit/fields/{fieldName}		GET		_apis/wit/fields/System.IterationPath?api-version=1.0
/wit/workitems/{taskId}/history		GET		_apis/wit/workitems/299/history?api-version=1.0
/wit/workitems/{taskId}/history/2		GET		_apis/wit/workitems/299/history/2?api-version=1.0
/wit/queries/My Queries/{folderNameNew}		DELETE		{project}/_apis/wit/queries/My%20Queries/Website?api-version=1.0
/wit/queries/{folderId}		DELETE		{project}/_apis/wit/queries/addcb8b3-12d0-4f2c-b6ca-52bb584ae286?api-version=1.0
/wit/queries/{hierarchicalQueryId}		DELETE		{project}/_apis/wit/queries/f0ade206-32f8-4360-9254-ad33f906cd2e?api-version=1.0
/wit/queries/{queryId}		DELETE		{project}/_apis/wit/queries/df60fdf6-3b5f-4928-aae8-29ee63df6e31?api-version=1.0
/wit/queries		GET		{project}/_apis/wit/queries?api-version=1.0
/wit/queries/Shared Queries/Current Sprint		GET		{project}/_apis/wit/queries/Shared%20Queries/Current%20Sprint?api-version=1.0
/wit/queries/Shared Queries/{folderName}		GET		{project}/_apis/wit/queries/Shared%20Queries/Website%20team?api-version=1.0
/wit/queries/Shared Queries/{folderName}/{queryName}		GET		{project}/_apis/wit/queries/Shared%20Queries/Website%20team/All%20Bugs?api-version=1.0
/wit/queries/{folderId}		GET		{project}/_apis/wit/queries/addcb8b3-12d0-4f2c-b6ca-52bb584ae286?api-version=1.0
/wit/queries/{hierarchicalQueryId}		GET		{project}/_apis/wit/queries/f0ade206-32f8-4360-9254-ad33f906cd2e?$expand=clauses&api-version=1.0
/wit/queries/{queryId}		GET		{project}/_apis/wit/queries/df60fdf6-3b5f-4928-aae8-29ee63df6e31?api-version=1.0
/wit/queries/Shared Queries/{folderName}		PATCH		{project}/_apis/wit/queries/Shared%20Queries/Website%20team?api-version=1.0
/wit/queries/Shared Queries/{folderName}/{queryNameNew}		PATCH		{project}/_apis/wit/queries/Shared%20Queries/Website%20team/Active%20Bugs?api-version=1.0
/wit/queries/{folderId}		PATCH		{project}/_apis/wit/queries/addcb8b3-12d0-4f2c-b6ca-52bb584ae286?$undeleteDescendants=true&api-version=1.0
/wit/queries/{queryId}		PATCH		{project}/_apis/wit/queries/df60fdf6-3b5f-4928-aae8-29ee63df6e31?api-version=1.0
/wit/queries/My Queries		POST		{project}/_apis/wit/queries/My%20Queries?api-version=1.0
/wit/queries/Shared Queries		POST		{project}/_apis/wit/queries/Shared%20Queries?api-version=1.0
/wit/queries/Shared Queries/{folderName}		POST		{project}/_apis/wit/queries/Shared%20Queries/Website%20team?api-version=1.0
/wit/workitemrelationtypes		GET		_apis/wit/workitemrelationtypes?api-version=1.0
/wit/workitemrelationtypes/{relationName}		GET		_apis/wit/workitemrelationtypes/System.LinkTypes.Related?api-version=1.0
/wit/workitems/{taskId}/revisions		GET		_apis/wit/workitems/299/revisions?api-version=1.0
/wit/workitems/{taskId}/revisions/2		GET		_apis/wit/workitems/299/revisions/2?api-version=1.0
/tagging/scopes/{scopeId}/tags/{tagId}		DELETE		_apis/tagging/scopes/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/tags/9dfc2f21-b2aa-4e11-a36a-f3761e9861cb?api-version=1.0
/tagging/scopes/{scopeId}/tags		GET		_apis/tagging/scopes/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/tags?api-version=1.0
/tagging/scopes/{scopeId}/tags/{name}		GET		_apis/tagging/scopes/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/tags/My%20Tag?api-version=1.0
/tagging/scopes/{scopeId}/tags/{tagId}		GET		_apis/tagging/scopes/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/tags/9dfc2f21-b2aa-4e11-a36a-f3761e9861cb?api-version=1.0
/tagging/scopes/{scopeId}/tags/{tagId}		PATCH		_apis/tagging/scopes/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/tags/9dfc2f21-b2aa-4e11-a36a-f3761e9861cb?api-version=1.0
/tagging/scopes/{scopeId}/tags		POST		_apis/tagging/scopes/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/tags?api-version=1.0
/wit/workitems/{taskId}/updates		GET		_apis/wit/workitems/299/updates?api-version=1.0
/wit/workitems/{taskId}/updates/2		GET		_apis/wit/workitems/299/updates/2?api-version=1.0
/wit/workitems/{taskId}/updates/4		GET		_apis/wit/workitems/299/updates/4?api-version=1.0
/wit/wiql/{queryId}		GET		{project}/_apis/wit/wiql/1e4e5b17-f212-4ba2-9c2f-a95600ef50a5?api-version=1.0
/wit/wiql		POST		{project}/_apis/wit/wiql?api-version=1.0
/wit/workitems		GET		_apis/wit/workitems?ids=297,299,300&api-version=1.0
/wit/WorkItems		GET		_apis/wit/WorkItems?ids=300,299,298,17,16,15,14,9,8&fields=System.Id,System.Title,System.State&asOf=2014-12-29T20:49:34.617Z&api-version=1.0
/wit/workitems/{PBIId}		GET		_apis/wit/workitems/297?api-version=1.0
/wit/workitems/$Task		GET		{project}/_apis/wit/workitems/$Task?api-version=1.0
/wit/workitems/$Task		PATCH		{project}/_apis/wit/workitems/$Task?api-version=1.0
/wit/workitems/{taskId}		PATCH		_apis/wit/workitems/299?api-version=1.0
/wit/workItemTypes		GET		{project}/_apis/wit/workItemTypes?api-version=1.0
/wit/workItemTypes/Bug		GET		{project}/_apis/wit/workItemTypes/Bug?api-version=1.0
         */
        /// <summary>
        ///     Gets the areas.
        /// </summary>
        /// <value>The areas.</value>
        internal static CallSpec Areas { get { return sr_Areas; } }

        /// <summary>
        ///     Gets the attachments.
        /// </summary>
        /// <value>The attachments.</value>
        internal static CallSpec Attachments { get { return sr_Attachments; } }

        /// <summary>
        ///     Gets the classification nodes.
        /// </summary>
        /// <value>The classification nodes.</value>
        internal static CallSpec ClassificationNodes { get { return sr_ClassificationNodes; } }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        internal static CallSpec FieldDefinitions { get { return sr_FieldDefinitions; } }

        /// <summary>
        ///     Gets the history.
        /// </summary>
        /// <value>The history.</value>
        internal static CallSpec History { get { return sr_History; } }

        /// <summary>
        /// Gets all iterations.
        /// </summary>
        /// <value>All iterations.</value>
        internal static CallSpec AllIterations { get { return sr_AllIterations; } }

        /// <summary>
        /// Gets the iterations in path.
        /// </summary>
        /// <value>The iterations in path.</value>
        internal static CallSpec IterationsInPath { get { return sr_IterationsInPath; } }

        /// <summary>
        ///     Gets the queries0.
        /// </summary>
        /// <value>The queries0.</value>
        internal static CallSpec Queries0 { get { return sr_Queries0; } }

        /// <summary>
        /// Gets all project queries.
        /// </summary>
        /// <value>All project queries.</value>
        internal static CallSpec AllProjectQueries { get { return sr_AllProjectQueries; } }

        /// <summary>
        /// Gets the project queries in path.
        /// </summary>
        /// <value>The project queries in path.</value>
        internal static CallSpec ProjectQueriesInPath { get { return sr_ProjectQueriesInPath; } }
  
            /// <summary>
        ///     Gets the query results.
        /// </summary>
        /// <value>The query results.</value>
        internal static CallSpec QueryResults { get { return sr_QueryResults; } }

        /// <summary>
        ///     Gets the revisions.
        /// </summary>
        /// <value>The revisions.</value>
        internal static CallSpec Revisions { get { return sr_Revisions; } }

        /// <summary>
        /// Gets the revision.
        /// </summary>
        /// <value>The revision.</value>
        internal static CallSpec Revision { get { return sr_Revision; } }

        
        /// <summary>
        ///     Gets the rule engine.
        /// </summary>
        /// <value>The rule engine.</value>
        internal static CallSpec RuleEngine { get { return sr_RuleEngine; } }

        /// <summary>
        ///     Gets the updates.
        /// </summary>
        /// <value>The updates.</value>
        internal static CallSpec Updates { get { return sr_Updates; } }

        /// <summary>
        ///     Gets the wiql0.
        /// </summary>
        /// <value>The wiql0.</value>
        internal static CallSpec Wiql0 { get { return sr_Wiql0; } }

        /// <summary>
        ///     Gets the wiql1.
        /// </summary>
        /// <value>The wiql1.</value>
        internal static CallSpec Wiql1 { get { return sr_Wiql1; } }

        /// <summary>
        ///     Gets the work item relation types.
        /// </summary>
        /// <value>The work item relation types.</value>
        internal static CallSpec WorkItemRelationTypes { get { return sr_WorkItemRelationTypes; } }

        /// <summary>
        ///     Gets the work item type categories.
        /// </summary>
        /// <value>The work item type categories.</value>
        internal static CallSpec WorkItemTypeCategories { get { return sr_WorkItemTypeCategories; } }

        /// <summary>
        ///     Gets the work item type template.
        /// </summary>
        /// <value>The work item type template.</value>
        internal static CallSpec WorkItemTypeTemplate { get { return sr_WorkItemTypeTemplate; } }

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        internal static CallSpec WorkItemTypes { get { return sr_WorkItemTypes; } }

        /// <summary>
        ///     Gets the work item types field.
        /// </summary>
        /// <value>The work item types field.</value>
        internal static CallSpec WorkItemTypesField { get { return sr_WorkItemTypesField; } }

        /// <summary>
        ///     Gets the work items0.
        /// </summary>
        /// <value>The work items0.</value>
        internal static CallSpec WorkItems { get { return sr_WorkItems; } }

        /// <summary>
        /// Gets the work items.
        /// </summary>
        /// <value>The work items.</value>
        internal static CallSpec WorkItem { get { return sr_WorkItem; } }

        /// <summary>
        ///     Gets the work items1.
        /// </summary>
        /// <value>The work items1.</value>
        internal static CallSpec WorkItems1 { get { return sr_WorkItems1; } }

        /// <summary>
        ///     The SR_ areas
        /// </summary>
        private static readonly CallSpec sr_Areas = new CallSpec("{project}/_apis/wit/classificationNodes/areas/{*path}");

        /// <summary>
        ///     The SR_ attachments
        /// </summary>
        private static readonly CallSpec sr_Attachments = new CallSpec("_apis/wit/attachments/{id}");

        /// <summary>
        ///     The SR_ classification nodes
        /// </summary>
        private static readonly CallSpec sr_ClassificationNodes = new CallSpec("{project}/_apis/wit/classificationNodes");

        /// <summary>
        /// The SR_ field definitions
        /// </summary>
        private static readonly CallSpec sr_FieldDefinitions = new CallSpec("_apis/wit/fields");
        private static readonly CallSpec sr_FieldDefinition = new CallSpec("_apis/wit/fields/{field}");

        /// <summary>
        ///     The SR_ history
        /// </summary>
        private static readonly CallSpec sr_History = new CallSpec("_apis/wit/workItems/{id}/history/{revisionNumber}");

        /// <summary>
        ///     The SR_ iterations
        /// </summary>
        private static readonly CallSpec sr_AllIterations = new CallSpec("{project}/_apis/wit/classificationNodes/iterations");
        private static readonly CallSpec sr_IterationsInPath = new CallSpec("{project}/_apis/wit/classificationNodes/iterations/{*path}");

        /// <summary>
        ///     The SR_ queries0
        /// </summary>
        private static readonly CallSpec sr_Queries0 = new CallSpec("_apis/wit/queries/{id}");

        /// <summary>
        ///     The SR_ queries1
        /// </summary>
        private static readonly CallSpec sr_AllProjectQueries = new CallSpec("{project}/_apis/wit/queries");
        private static readonly CallSpec sr_ProjectQueriesInPath = new CallSpec("{project}/_apis/wit/queries/{*query}");

        /// <summary>
        ///     The SR_ query results
        /// </summary>
        private static readonly CallSpec sr_QueryResults = new CallSpec("_apis/wit/queryResults/{id}");

        /// <summary>
        ///     The SR_ revisions
        /// </summary>
        private static readonly CallSpec sr_Revisions = new CallSpec("_apis/wit/workItems/{id}/revisions");
        private static readonly CallSpec sr_Revision = new CallSpec("_apis/wit/workItems/{id}/revisions/{revisionNumber}");

        /// <summary>
        ///     The SR_ rule engine
        /// </summary>
        private static readonly CallSpec sr_RuleEngine = new CallSpec("_apis/wit/$ruleEngine");

        /// <summary>
        ///     The SR_ updates
        /// </summary>
        private static readonly CallSpec sr_Updates = new CallSpec("_apis/wit/workItems/{id}/updates/{updateNumber}");

        /// <summary>
        ///     The SR_ wiql0
        /// </summary>
        private static readonly CallSpec sr_Wiql0 = new CallSpec("{project}/_apis/wit/wiql/{id}");

        /// <summary>
        ///     The SR_ wiql1
        /// </summary>
        private static readonly CallSpec sr_Wiql1 = new CallSpec("{project}/_apis/wit/wiql");

        /// <summary>
        ///     The SR_ work item relation types
        /// </summary>
        private static readonly CallSpec sr_WorkItemRelationTypes = new CallSpec("_apis/wit/workItemRelationTypes");
        private static readonly CallSpec sr_WorkItemRelationType = new CallSpec("_apis/wit/workItemRelationTypes/{relation}");

        /// <summary>
        ///     The SR_ work item type categories
        /// </summary>
        private static readonly CallSpec sr_WorkItemTypeCategories = new CallSpec("{project}/_apis/wit/workItemTypeCategories");
        private static readonly CallSpec sr_WorkItemTypeCategory = new CallSpec("{project}/_apis/wit/workItemTypeCategories/{category}");

        /// <summary>
        ///     The SR_ work item type template
        /// </summary>
        private static readonly CallSpec sr_WorkItemTypeTemplate = new CallSpec("{project}/_apis/wit/workItemTypeTemplate/{type}");

        /// <summary>
        ///     The SR_ work item types
        /// </summary>
        private static readonly CallSpec sr_WorkItemTypes = new CallSpec("{project}/_apis/wit/workItemTypes");
        private static readonly CallSpec sr_WorkItemType = new CallSpec("{project}/_apis/wit/workItemTypes/{type}");

        /// <summary>
        ///     The SR_ work item types field
        /// </summary>
        private static readonly CallSpec sr_WorkItemTypesField = new CallSpec("{project}/_apis/wit/workitemtypes/{type}/fields/{field}");

        /// <summary>
        ///     The SR_ work items0
        /// </summary>
        private static readonly CallSpec sr_WorkItems = new CallSpec("_apis/wit/workItems");
        private static readonly CallSpec sr_WorkItem = new CallSpec("_apis/wit/workItems/{id}");

        /// <summary>
        ///     The SR_ work items1
        /// </summary>
        private static readonly CallSpec sr_WorkItems1 = new CallSpec("{project}/_apis/wit/workItems/${type}");
    }
}