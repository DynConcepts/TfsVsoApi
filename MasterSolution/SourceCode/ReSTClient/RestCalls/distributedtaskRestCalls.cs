using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class distributedtaskRestCalls.
    /// </summary>
    internal class distributedtaskRestCalls
    {
        /// <summary>
        ///     Gets the feed.
        /// </summary>
        /// <value>The feed.</value>
        internal static CallSpec Feed { get { return sr_Feed; } }

        /// <summary>
        ///     Gets the index.
        /// </summary>
        /// <value>The index.</value>
        internal static CallSpec Index { get { return sr_Index; } }

        /// <summary>
        ///     Gets the logs.
        /// </summary>
        /// <value>The logs.</value>
        internal static CallSpec Logs { get { return sr_Logs; } }

        /// <summary>
        ///     Gets the plans.
        /// </summary>
        /// <value>The plans.</value>
        internal static CallSpec Plans { get { return sr_Plans; } }

        /// <summary>
        ///     Gets the records.
        /// </summary>
        /// <value>The records.</value>
        internal static CallSpec Records { get { return sr_Records; } }

        /// <summary>
        ///     Gets the timelines.
        /// </summary>
        /// <value>The timelines.</value>
        internal static CallSpec Timelines { get { return sr_Timelines; } }

        /// <summary>
        ///     The SR_ feed
        /// </summary>
        private static readonly CallSpec sr_Feed = new CallSpec("_apis/distributedtask/plans/{planId}/timelines/{timelineId}/records/{recordId}/feed");

        /// <summary>
        ///     The SR_ index
        /// </summary>
        private static readonly CallSpec sr_Index = new CallSpec("_apis/distributedtask/plans/{planId}/logs/{logId}/index");

        /// <summary>
        ///     The SR_ logs
        /// </summary>
        private static readonly CallSpec sr_Logs = new CallSpec("_apis/distributedtask/plans/{planId}/logs/{logId}");

        /// <summary>
        ///     The SR_ plans
        /// </summary>
        private static readonly CallSpec sr_Plans = new CallSpec("_apis/distributedtask/plans/{planId}");

        /// <summary>
        ///     The SR_ records
        /// </summary>
        private static readonly CallSpec sr_Records = new CallSpec("_apis/distributedtask/plans/{planId}/timelines/{timelineId}/records/{recordId}");

        /// <summary>
        ///     The SR_ timelines
        /// </summary>
        private static readonly CallSpec sr_Timelines = new CallSpec("_apis/distributedtask/plans/{planId}/timelines/{timelineId}");
    }
}