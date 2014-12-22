class ReportingRestCalls
{
 internal static CallSpec ChartConfiguration { get { return sr_ChartConfiguration; } }
 private static readonly CallSpec sr_ChartConfiguration= new CallSpec("_apis/Reporting/ChartConfiguration/{id}");
 internal static CallSpec DataServiceCapabilities { get { return sr_DataServiceCapabilities; } }
 private static readonly CallSpec sr_DataServiceCapabilities= new CallSpec("_apis/Reporting/DataServiceCapabilities/{scope}");
 internal static CallSpec TransformQuery { get { return sr_TransformQuery; } }
 private static readonly CallSpec sr_TransformQuery= new CallSpec("_apis/Reporting/TransformQuery/{scope}");
}
