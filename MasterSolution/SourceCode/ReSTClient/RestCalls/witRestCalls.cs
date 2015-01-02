using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class WitRestCalls.
    /// </summary>
    internal class WitRestCalls
    {
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
        internal static CallSpec Fields { get { return sr_Fields; } }

        /// <summary>
        ///     Gets the history.
        /// </summary>
        /// <value>The history.</value>
        internal static CallSpec History { get { return sr_History; } }

        /// <summary>
        ///     Gets the iterations.
        /// </summary>
        /// <value>The iterations.</value>
        internal static CallSpec Iterations { get { return sr_Iterations; } }

        /// <summary>
        ///     Gets the queries0.
        /// </summary>
        /// <value>The queries0.</value>
        internal static CallSpec Queries0 { get { return sr_Queries0; } }

        /// <summary>
        ///     Gets the queries1.
        /// </summary>
        /// <value>The queries1.</value>
        internal static CallSpec Queries1 { get { return sr_Queries1; } }

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
        internal static CallSpec WorkItems0 { get { return sr_WorkItems0; } }

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
        ///     The SR_ fields
        /// </summary>
        private static readonly CallSpec sr_Fields = new CallSpec("_apis/wit/fields/{field}");

        /// <summary>
        ///     The SR_ history
        /// </summary>
        private static readonly CallSpec sr_History = new CallSpec("_apis/wit/workItems/{id}/history/{revisionNumber}");

        /// <summary>
        ///     The SR_ iterations
        /// </summary>
        private static readonly CallSpec sr_Iterations = new CallSpec("{project}/_apis/wit/classificationNodes/iterations/{*path}");

        /// <summary>
        ///     The SR_ queries0
        /// </summary>
        private static readonly CallSpec sr_Queries0 = new CallSpec("_apis/wit/queries/{id}");

        /// <summary>
        ///     The SR_ queries1
        /// </summary>
        private static readonly CallSpec sr_Queries1 = new CallSpec("{project}/_apis/wit/queries/{*query}");

        /// <summary>
        ///     The SR_ query results
        /// </summary>
        private static readonly CallSpec sr_QueryResults = new CallSpec("_apis/wit/queryResults/{id}");

        /// <summary>
        ///     The SR_ revisions
        /// </summary>
        private static readonly CallSpec sr_Revisions = new CallSpec("_apis/wit/workItems/{id}/revisions/{revisionNumber}");

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
        private static readonly CallSpec sr_WorkItemRelationTypes = new CallSpec("_apis/wit/workItemRelationTypes/{relation}");

        /// <summary>
        ///     The SR_ work item type categories
        /// </summary>
        private static readonly CallSpec sr_WorkItemTypeCategories = new CallSpec("{project}/_apis/wit/workItemTypeCategories/{category}");

        /// <summary>
        ///     The SR_ work item type template
        /// </summary>
        private static readonly CallSpec sr_WorkItemTypeTemplate = new CallSpec("{project}/_apis/wit/workItemTypeTemplate/{type}");

        /// <summary>
        ///     The SR_ work item types
        /// </summary>
        private static readonly CallSpec sr_WorkItemTypes = new CallSpec("{project}/_apis/wit/workItemTypes/{type}");

        /// <summary>
        ///     The SR_ work item types field
        /// </summary>
        private static readonly CallSpec sr_WorkItemTypesField = new CallSpec("{project}/_apis/wit/workitemtypes/{type}/fields/{field}");

        /// <summary>
        ///     The SR_ work items0
        /// </summary>
        private static readonly CallSpec sr_WorkItems0 = new CallSpec("_apis/wit/workItems/{id}");

        /// <summary>
        ///     The SR_ work items1
        /// </summary>
        private static readonly CallSpec sr_WorkItems1 = new CallSpec("{project}/_apis/wit/workItems/${type}");
    }
}