class TestRestCalls
{
 internal static CallSpec Plans_0 { get { return sr_Plans_0; } }
 private static readonly CallSpec sr_Plans_0= new CallSpec("_apis/test/{projectId}/Plans/{planId}");
 internal static CallSpec Plans_1 { get { return sr_Plans_1; } }
 private static readonly CallSpec sr_Plans_1= new CallSpec("{project}/_apis/test/Plans/{planId}");
 internal static CallSpec Points_0 { get { return sr_Points_0; } }
 private static readonly CallSpec sr_Points_0= new CallSpec("_apis/test/{projectId}/Plans/{planId}/Suites/{suiteId}/Points/{pointIds}");
 internal static CallSpec Points_1 { get { return sr_Points_1; } }
 private static readonly CallSpec sr_Points_1= new CallSpec("{project}/_apis/test/Plans/{planId}/Suites/{suiteId}/Points/{pointIds}");
 internal static CallSpec Suites_0 { get { return sr_Suites_0; } }
 private static readonly CallSpec sr_Suites_0= new CallSpec("_apis/test/{projectId}/Plans/{planId}/Suites/{suiteId}");
 internal static CallSpec Suites_1 { get { return sr_Suites_1; } }
 private static readonly CallSpec sr_Suites_1= new CallSpec("{project}/_apis/test/Plans/{planId}/Suites/{suiteId}");
 internal static CallSpec Suites_2 { get { return sr_Suites_2; } }
 private static readonly CallSpec sr_Suites_2= new CallSpec("_apis/test/Suites");
 internal static CallSpec Suites_3 { get { return sr_Suites_3; } }
 private static readonly CallSpec sr_Suites_3= new CallSpec("_apis/test/{projectId}/Plans/{planId}/Suites/{suiteId}/{action}/{testCaseIds}");
 internal static CallSpec Suites_4 { get { return sr_Suites_4; } }
 private static readonly CallSpec sr_Suites_4= new CallSpec("{project}/_apis/test/Plans/{planId}/Suites/{suiteId}/{action}/{testCaseIds}");
 internal static CallSpec Runs_0 { get { return sr_Runs_0; } }
 private static readonly CallSpec sr_Runs_0= new CallSpec("_apis/test/{projectId}/Runs/{runId}");
 internal static CallSpec Runs_1 { get { return sr_Runs_1; } }
 private static readonly CallSpec sr_Runs_1= new CallSpec("{project}/_apis/test/Runs/{runId}");
 internal static CallSpec Runs_2 { get { return sr_Runs_2; } }
 private static readonly CallSpec sr_Runs_2= new CallSpec("_apis/test/{projectId}/Runs/{runId}/Statistics");
 internal static CallSpec Runs_3 { get { return sr_Runs_3; } }
 private static readonly CallSpec sr_Runs_3= new CallSpec("{project}/_apis/test/Runs/{runId}/Statistics");
 internal static CallSpec Runs_4 { get { return sr_Runs_4; } }
 private static readonly CallSpec sr_Runs_4= new CallSpec("_apis/test/{projectId}/Runs/{runId}/Coverage");
 internal static CallSpec Runs_5 { get { return sr_Runs_5; } }
 private static readonly CallSpec sr_Runs_5= new CallSpec("{project}/_apis/test/Runs/{runId}/Coverage");
 internal static CallSpec Results_0 { get { return sr_Results_0; } }
 private static readonly CallSpec sr_Results_0= new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}");
 internal static CallSpec Results_1 { get { return sr_Results_1; } }
 private static readonly CallSpec sr_Results_1= new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}");
 internal static CallSpec Results_2 { get { return sr_Results_2; } }
 private static readonly CallSpec sr_Results_2= new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}");
 internal static CallSpec Results_3 { get { return sr_Results_3; } }
 private static readonly CallSpec sr_Results_3= new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}");
 internal static CallSpec Results_4 { get { return sr_Results_4; } }
 private static readonly CallSpec sr_Results_4= new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}");
 internal static CallSpec Results_5 { get { return sr_Results_5; } }
 private static readonly CallSpec sr_Results_5= new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}");
 internal static CallSpec Results_6 { get { return sr_Results_6; } }
 private static readonly CallSpec sr_Results_6= new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}/{actionPath}");
 internal static CallSpec Results_7 { get { return sr_Results_7; } }
 private static readonly CallSpec sr_Results_7= new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}/{actionPath}");
 internal static CallSpec Results_4b { get { return sr_Results_4; } }
 private static readonly CallSpec sr_Results_4b= new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}");
 internal static CallSpec Results_5b { get { return sr_Results_5; } }
 private static readonly CallSpec sr_Results_5b= new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}");
 internal static CallSpec Results2 { get { return sr_Results2; } }
 private static readonly CallSpec sr_Results2= new CallSpec("_apis/test/{projectId}/Results2/{testCaseResultId}");
 internal static CallSpec Agents { get { return sr_Agents; } }
 private static readonly CallSpec sr_Agents= new CallSpec("_apis/test/Agents/{id}");
 internal static CallSpec AutomationRuns { get { return sr_AutomationRuns; } }
 private static readonly CallSpec sr_AutomationRuns= new CallSpec("_apis/test/AutomationRuns");
 internal static CallSpec Slices { get { return sr_Slices; } }
 private static readonly CallSpec sr_Slices= new CallSpec("_apis/test/Slices/{testAgentId}");
 internal static CallSpec Commands { get { return sr_Commands; } }
 private static readonly CallSpec sr_Commands= new CallSpec("_apis/test/Agents/{testagentId}/Commands/{commandId}");
}
