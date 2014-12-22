class codelensRestCalls
{
 internal static CallSpec filedetails { get { return sr_filedetails; } }
 private static readonly CallSpec sr_filedetails= new CallSpec("_apis/codelens/filedetails");
 internal static CallSpec filesummaries { get { return sr_filesummaries; } }
 private static readonly CallSpec sr_filesummaries= new CallSpec("_apis/codelens/filesummaries");
}
