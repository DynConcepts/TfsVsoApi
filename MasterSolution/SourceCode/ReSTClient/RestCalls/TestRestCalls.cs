using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class TestRestCalls.
    /// </summary>
    internal class TestRestCalls
    {
        /// <summary>
        ///     Gets the agents.
        /// </summary>
        /// <value>The agents.</value>
        internal static CallSpec Agents { get { return sr_Agents; } }

        /// <summary>
        ///     Gets the automation runs.
        /// </summary>
        /// <value>The automation runs.</value>
        internal static CallSpec AutomationRuns { get { return sr_AutomationRuns; } }

        /// <summary>
        ///     Gets the commands.
        /// </summary>
        /// <value>The commands.</value>
        internal static CallSpec Commands { get { return sr_Commands; } }

        /// <summary>
        ///     Gets the plans_0.
        /// </summary>
        /// <value>The plans_0.</value>
        internal static CallSpec Plans_0 { get { return sr_Plans_0; } }

        /// <summary>
        ///     Gets the plans_1.
        /// </summary>
        /// <value>The plans_1.</value>
        internal static CallSpec Plans_1 { get { return sr_Plans_1; } }

        /// <summary>
        ///     Gets the points_0.
        /// </summary>
        /// <value>The points_0.</value>
        internal static CallSpec Points_0 { get { return sr_Points_0; } }

        /// <summary>
        ///     Gets the points_1.
        /// </summary>
        /// <value>The points_1.</value>
        internal static CallSpec Points_1 { get { return sr_Points_1; } }

        /// <summary>
        ///     Gets the results2.
        /// </summary>
        /// <value>The results2.</value>
        internal static CallSpec Results2 { get { return sr_Results2; } }

        /// <summary>
        ///     Gets the results_0.
        /// </summary>
        /// <value>The results_0.</value>
        internal static CallSpec Results_0 { get { return sr_Results_0; } }

        /// <summary>
        ///     Gets the results_1.
        /// </summary>
        /// <value>The results_1.</value>
        internal static CallSpec Results_1 { get { return sr_Results_1; } }

        /// <summary>
        ///     Gets the results_2.
        /// </summary>
        /// <value>The results_2.</value>
        internal static CallSpec Results_2 { get { return sr_Results_2; } }

        /// <summary>
        ///     Gets the results_3.
        /// </summary>
        /// <value>The results_3.</value>
        internal static CallSpec Results_3 { get { return sr_Results_3; } }

        /// <summary>
        ///     Gets the results_4.
        /// </summary>
        /// <value>The results_4.</value>
        internal static CallSpec Results_4 { get { return sr_Results_4; } }

        /// <summary>
        ///     Gets the results_4b.
        /// </summary>
        /// <value>The results_4b.</value>
        internal static CallSpec Results_4b { get { return sr_Results_4; } }

        /// <summary>
        ///     Gets the results_5.
        /// </summary>
        /// <value>The results_5.</value>
        internal static CallSpec Results_5 { get { return sr_Results_5; } }

        /// <summary>
        ///     Gets the results_5b.
        /// </summary>
        /// <value>The results_5b.</value>
        internal static CallSpec Results_5b { get { return sr_Results_5; } }

        /// <summary>
        ///     Gets the results_6.
        /// </summary>
        /// <value>The results_6.</value>
        internal static CallSpec Results_6 { get { return sr_Results_6; } }

        /// <summary>
        ///     Gets the results_7.
        /// </summary>
        /// <value>The results_7.</value>
        internal static CallSpec Results_7 { get { return sr_Results_7; } }

        /// <summary>
        ///     Gets the runs_0.
        /// </summary>
        /// <value>The runs_0.</value>
        internal static CallSpec Runs_0 { get { return sr_Runs_0; } }

        /// <summary>
        ///     Gets the runs_1.
        /// </summary>
        /// <value>The runs_1.</value>
        internal static CallSpec Runs_1 { get { return sr_Runs_1; } }

        /// <summary>
        ///     Gets the runs_2.
        /// </summary>
        /// <value>The runs_2.</value>
        internal static CallSpec Runs_2 { get { return sr_Runs_2; } }

        /// <summary>
        ///     Gets the runs_3.
        /// </summary>
        /// <value>The runs_3.</value>
        internal static CallSpec Runs_3 { get { return sr_Runs_3; } }

        /// <summary>
        ///     Gets the runs_4.
        /// </summary>
        /// <value>The runs_4.</value>
        internal static CallSpec Runs_4 { get { return sr_Runs_4; } }

        /// <summary>
        ///     Gets the runs_5.
        /// </summary>
        /// <value>The runs_5.</value>
        internal static CallSpec Runs_5 { get { return sr_Runs_5; } }

        /// <summary>
        ///     Gets the slices.
        /// </summary>
        /// <value>The slices.</value>
        internal static CallSpec Slices { get { return sr_Slices; } }

        /// <summary>
        ///     Gets the suites_0.
        /// </summary>
        /// <value>The suites_0.</value>
        internal static CallSpec Suites_0 { get { return sr_Suites_0; } }

        /// <summary>
        ///     Gets the suites_1.
        /// </summary>
        /// <value>The suites_1.</value>
        internal static CallSpec Suites_1 { get { return sr_Suites_1; } }

        /// <summary>
        ///     Gets the suites_2.
        /// </summary>
        /// <value>The suites_2.</value>
        internal static CallSpec Suites_2 { get { return sr_Suites_2; } }

        /// <summary>
        ///     Gets the suites_3.
        /// </summary>
        /// <value>The suites_3.</value>
        internal static CallSpec Suites_3 { get { return sr_Suites_3; } }

        /// <summary>
        ///     Gets the suites_4.
        /// </summary>
        /// <value>The suites_4.</value>
        internal static CallSpec Suites_4 { get { return sr_Suites_4; } }

        /// <summary>
        ///     The SR_ agents
        /// </summary>
        private static readonly CallSpec sr_Agents = new CallSpec("_apis/test/Agents/{id}");

        /// <summary>
        ///     The SR_ automation runs
        /// </summary>
        private static readonly CallSpec sr_AutomationRuns = new CallSpec("_apis/test/AutomationRuns");

        /// <summary>
        ///     The SR_ commands
        /// </summary>
        private static readonly CallSpec sr_Commands = new CallSpec("_apis/test/Agents/{testagentId}/Commands/{commandId}");

        /// <summary>
        ///     The SR_ plans_0
        /// </summary>
        private static readonly CallSpec sr_Plans_0 = new CallSpec("_apis/test/{projectId}/Plans/{planId}");

        /// <summary>
        ///     The SR_ plans_1
        /// </summary>
        private static readonly CallSpec sr_Plans_1 = new CallSpec("{project}/_apis/test/Plans/{planId}");

        /// <summary>
        ///     The SR_ points_0
        /// </summary>
        private static readonly CallSpec sr_Points_0 = new CallSpec("_apis/test/{projectId}/Plans/{planId}/Suites/{suiteId}/Points/{pointIds}");

        /// <summary>
        ///     The SR_ points_1
        /// </summary>
        private static readonly CallSpec sr_Points_1 = new CallSpec("{project}/_apis/test/Plans/{planId}/Suites/{suiteId}/Points/{pointIds}");

        /// <summary>
        ///     The SR_ results2
        /// </summary>
        private static readonly CallSpec sr_Results2 = new CallSpec("_apis/test/{projectId}/Results2/{testCaseResultId}");

        /// <summary>
        ///     The SR_ results_0
        /// </summary>
        private static readonly CallSpec sr_Results_0 = new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}");

        /// <summary>
        ///     The SR_ results_1
        /// </summary>
        private static readonly CallSpec sr_Results_1 = new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}");

        /// <summary>
        ///     The SR_ results_2
        /// </summary>
        private static readonly CallSpec sr_Results_2 = new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}");

        /// <summary>
        ///     The SR_ results_3
        /// </summary>
        private static readonly CallSpec sr_Results_3 = new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}");

        /// <summary>
        ///     The SR_ results_4
        /// </summary>
        private static readonly CallSpec sr_Results_4 = new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}");

        /// <summary>
        ///     The SR_ results_4b
        /// </summary>
        private static readonly CallSpec sr_Results_4b = new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}");

        /// <summary>
        ///     The SR_ results_5
        /// </summary>
        private static readonly CallSpec sr_Results_5 = new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}");

        /// <summary>
        ///     The SR_ results_5b
        /// </summary>
        private static readonly CallSpec sr_Results_5b = new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}");

        /// <summary>
        ///     The SR_ results_6
        /// </summary>
        private static readonly CallSpec sr_Results_6 = new CallSpec("_apis/test/{projectId}/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}/{actionPath}");

        /// <summary>
        ///     The SR_ results_7
        /// </summary>
        private static readonly CallSpec sr_Results_7 = new CallSpec("{project}/_apis/test/Runs/{runId}/Results/{testCaseResultId}/Iterations/{iterationId}/{action}/{actionPath}");

        /// <summary>
        ///     The SR_ runs_0
        /// </summary>
        private static readonly CallSpec sr_Runs_0 = new CallSpec("_apis/test/{projectId}/Runs/{runId}");

        /// <summary>
        ///     The SR_ runs_1
        /// </summary>
        private static readonly CallSpec sr_Runs_1 = new CallSpec("{project}/_apis/test/Runs/{runId}");

        /// <summary>
        ///     The SR_ runs_2
        /// </summary>
        private static readonly CallSpec sr_Runs_2 = new CallSpec("_apis/test/{projectId}/Runs/{runId}/Statistics");

        /// <summary>
        ///     The SR_ runs_3
        /// </summary>
        private static readonly CallSpec sr_Runs_3 = new CallSpec("{project}/_apis/test/Runs/{runId}/Statistics");

        /// <summary>
        ///     The SR_ runs_4
        /// </summary>
        private static readonly CallSpec sr_Runs_4 = new CallSpec("_apis/test/{projectId}/Runs/{runId}/Coverage");

        /// <summary>
        ///     The SR_ runs_5
        /// </summary>
        private static readonly CallSpec sr_Runs_5 = new CallSpec("{project}/_apis/test/Runs/{runId}/Coverage");

        /// <summary>
        ///     The SR_ slices
        /// </summary>
        private static readonly CallSpec sr_Slices = new CallSpec("_apis/test/Slices/{testAgentId}");

        /// <summary>
        ///     The SR_ suites_0
        /// </summary>
        private static readonly CallSpec sr_Suites_0 = new CallSpec("_apis/test/{projectId}/Plans/{planId}/Suites/{suiteId}");

        /// <summary>
        ///     The SR_ suites_1
        /// </summary>
        private static readonly CallSpec sr_Suites_1 = new CallSpec("{project}/_apis/test/Plans/{planId}/Suites/{suiteId}");

        /// <summary>
        ///     The SR_ suites_2
        /// </summary>
        private static readonly CallSpec sr_Suites_2 = new CallSpec("_apis/test/Suites");

        /// <summary>
        ///     The SR_ suites_3
        /// </summary>
        private static readonly CallSpec sr_Suites_3 = new CallSpec("_apis/test/{projectId}/Plans/{planId}/Suites/{suiteId}/{action}/{testCaseIds}");

        /// <summary>
        ///     The SR_ suites_4
        /// </summary>
        private static readonly CallSpec sr_Suites_4 = new CallSpec("{project}/_apis/test/Plans/{planId}/Suites/{suiteId}/{action}/{testCaseIds}");
    }
}