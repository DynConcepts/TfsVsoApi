class distributedtaskRestCalls
{
 internal static CallSpec plans { get { return sr_plans; } }
 private static readonly CallSpec sr_plans= new CallSpec("_apis/distributedtask/plans/{planId}");
 internal static CallSpec timelines { get { return sr_timelines; } }
 private static readonly CallSpec sr_timelines= new CallSpec("_apis/distributedtask/plans/{planId}/timelines/{timelineId}");
 internal static CallSpec records { get { return sr_records; } }
 private static readonly CallSpec sr_records= new CallSpec("_apis/distributedtask/plans/{planId}/timelines/{timelineId}/records/{recordId}");
 internal static CallSpec feed { get { return sr_feed; } }
 private static readonly CallSpec sr_feed= new CallSpec("_apis/distributedtask/plans/{planId}/timelines/{timelineId}/records/{recordId}/feed");
 internal static CallSpec logs { get { return sr_logs; } }
 private static readonly CallSpec sr_logs= new CallSpec("_apis/distributedtask/plans/{planId}/logs/{logId}");
 internal static CallSpec index { get { return sr_index; } }
 private static readonly CallSpec sr_index= new CallSpec("_apis/distributedtask/plans/{planId}/logs/{logId}/index");
}
