class ContainerRestCalls
{
 internal static CallSpec Containers { get { return sr_Containers; } }
 private static readonly CallSpec sr_Containers= new CallSpec("_apis/resources/Containers/{containerId}/{*itemPath}");
}
