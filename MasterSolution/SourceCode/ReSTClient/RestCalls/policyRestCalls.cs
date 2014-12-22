class policyRestCalls
{
 internal static CallSpec types { get { return sr_types; } }
 private static readonly CallSpec sr_types= new CallSpec("_apis/policy/types/{typeId}");
 internal static CallSpec configurations { get { return sr_configurations; } }
 private static readonly CallSpec sr_configurations= new CallSpec("_apis/policy/{projectId}/configurations/{configurationId}");
 internal static CallSpec versions { get { return sr_versions; } }
 private static readonly CallSpec sr_versions= new CallSpec("_apis/policy/{projectId}/configurations/{configurationId}/versions/{versionId}");
 internal static CallSpec evaluations_0 { get { return sr_evaluations_0; } }
 private static readonly CallSpec sr_evaluations_0= new CallSpec("_apis/policy/{projectId}/configurations/{configurationId}/evaluations");
 internal static CallSpec evaluations_1 { get { return sr_evaluations_1; } }
 private static readonly CallSpec sr_evaluations_1= new CallSpec("_apis/policy/{projectId}/evaluations");
}
