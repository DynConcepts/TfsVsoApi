class agileRestCalls
{
 internal static CallSpec backlogs { get { return sr_backlogs; } }
 private static readonly CallSpec sr_backlogs= new CallSpec("_apis/agile/backlogs/{id}");
}
