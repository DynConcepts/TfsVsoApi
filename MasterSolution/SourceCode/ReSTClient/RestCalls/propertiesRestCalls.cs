class propertiesRestCalls
{
 internal static CallSpec properties { get { return sr_properties; } }
 private static readonly CallSpec sr_properties= new CallSpec("_apis/properties/{id}");
}
