class LocationRestCalls
{
 internal static CallSpec ConnectionData { get { return sr_ConnectionData; } }
 private static readonly CallSpec sr_ConnectionData= new CallSpec("_apis/ConnectionData");
 internal static CallSpec ServiceDefinitions { get { return sr_ServiceDefinitions; } }
 private static readonly CallSpec sr_ServiceDefinitions= new CallSpec("_apis/ServiceDefinitions/{serviceType}/{identifier}");
}
