class buildRestCalls
{
 internal static CallSpec options { get { return sr_options; } }
 private static readonly CallSpec sr_options= new CallSpec("_apis/build/options");
 internal static CallSpec artifacts { get { return sr_artifacts; } }
 private static readonly CallSpec sr_artifacts= new CallSpec("_apis/build/builds/{buildId}/artifacts/{artifactName}");
 internal static CallSpec commits { get { return sr_commits; } }
 private static readonly CallSpec sr_commits= new CallSpec("{project}/_apis/build/builds/{buildId}/commits");
 internal static CallSpec logs { get { return sr_logs; } }
 private static readonly CallSpec sr_logs= new CallSpec("{project}/_apis/build/builds/{buildId}/logs");
 internal static CallSpec tags_0 { get { return sr_tags_0; } }
 private static readonly CallSpec sr_tags_0= new CallSpec("{project}/_apis/build/tags");
 internal static CallSpec tags_1 { get { return sr_tags_1; } }
 private static readonly CallSpec sr_tags_1= new CallSpec("{project}/_apis/build/builds/{buildId}/tags/{tag}");
 internal static CallSpec templates { get { return sr_templates; } }
 private static readonly CallSpec sr_templates= new CallSpec("{project}/_apis/build/definitions/templates/{templateId}");
 internal static CallSpec revisions { get { return sr_revisions; } }
 private static readonly CallSpec sr_revisions= new CallSpec("_apis/build/definitions/{definitionId}/revisions");


 internal static CallSpec definitions { get { return sr_definitions; } }
 private static readonly CallSpec sr_definitions = new CallSpec("{project}/_apis/build/definitions");
}
