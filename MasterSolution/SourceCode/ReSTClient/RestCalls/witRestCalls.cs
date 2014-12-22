class witRestCalls
{
 internal static CallSpec ruleEngine { get { return sr_ruleEngine; } }
 private static readonly CallSpec sr_ruleEngine= new CallSpec("_apis/wit/$ruleEngine");
 internal static CallSpec workItemTypeTemplate { get { return sr_workItemTypeTemplate; } }
 private static readonly CallSpec sr_workItemTypeTemplate= new CallSpec("{project}/_apis/wit/workItemTypeTemplate/{type}");
 internal static CallSpec workItemTypeCategories { get { return sr_workItemTypeCategories; } }
 private static readonly CallSpec sr_workItemTypeCategories= new CallSpec("{project}/_apis/wit/workItemTypeCategories/{category}");
 internal static CallSpec workItemTypes { get { return sr_workItemTypes; } }
 private static readonly CallSpec sr_workItemTypes= new CallSpec("{project}/_apis/wit/workItemTypes/{type}");
 internal static CallSpec workItemTypesField { get { return sr_workItemTypesField; } }
 private static readonly CallSpec sr_workItemTypesField= new CallSpec("{project}/_apis/wit/workitemtypes/{type}/fields/{field}");
 internal static CallSpec attachments { get { return sr_attachments; } }
 private static readonly CallSpec sr_attachments= new CallSpec("_apis/wit/attachments/{id}");
 internal static CallSpec fields { get { return sr_fields; } }
 private static readonly CallSpec sr_fields= new CallSpec("_apis/wit/fields/{field}");
 internal static CallSpec workItemRelationTypes { get { return sr_workItemRelationTypes; } }
 private static readonly CallSpec sr_workItemRelationTypes= new CallSpec("_apis/wit/workItemRelationTypes/{relation}");
 internal static CallSpec queryResults { get { return sr_queryResults; } }
 private static readonly CallSpec sr_queryResults= new CallSpec("_apis/wit/queryResults/{id}");
 internal static CallSpec wiql_0 { get { return sr_wiql_0; } }
 private static readonly CallSpec sr_wiql_0= new CallSpec("{project}/_apis/wit/wiql/{id}");
 internal static CallSpec wiql_1 { get { return sr_wiql_1; } }
 private static readonly CallSpec sr_wiql_1= new CallSpec("{project}/_apis/wit/wiql");
 internal static CallSpec queries_0 { get { return sr_queries_0; } }
 private static readonly CallSpec sr_queries_0= new CallSpec("_apis/wit/queries/{id}");
 internal static CallSpec queries_1 { get { return sr_queries_1; } }
 private static readonly CallSpec sr_queries_1= new CallSpec("{project}/_apis/wit/queries/{*query}");
 internal static CallSpec areas { get { return sr_areas; } }
 private static readonly CallSpec sr_areas= new CallSpec("{project}/_apis/wit/classificationNodes/areas/{*path}");
 internal static CallSpec iterations { get { return sr_iterations; } }
 private static readonly CallSpec sr_iterations= new CallSpec("{project}/_apis/wit/classificationNodes/iterations/{*path}");
 internal static CallSpec classificationNodes { get { return sr_classificationNodes; } }
 private static readonly CallSpec sr_classificationNodes= new CallSpec("{project}/_apis/wit/classificationNodes");
 internal static CallSpec revisions { get { return sr_revisions; } }
 private static readonly CallSpec sr_revisions= new CallSpec("_apis/wit/workItems/{id}/revisions/{revisionNumber}");
 internal static CallSpec updates { get { return sr_updates; } }
 private static readonly CallSpec sr_updates= new CallSpec("_apis/wit/workItems/{id}/updates/{updateNumber}");
 internal static CallSpec history { get { return sr_history; } }
 private static readonly CallSpec sr_history= new CallSpec("_apis/wit/workItems/{id}/history/{revisionNumber}");
 internal static CallSpec workItems_0 { get { return sr_workItems_0; } }
 private static readonly CallSpec sr_workItems_0= new CallSpec("_apis/wit/workItems/{id}");
 internal static CallSpec workItems_1 { get { return sr_workItems_1; } }
 private static readonly CallSpec sr_workItems_1= new CallSpec("{project}/_apis/wit/workItems/${type}");
}
