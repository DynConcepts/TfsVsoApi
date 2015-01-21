namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common
{
    /// <summary>
    /// Enum IRelativeToSetting
    /// </summary>
    public enum IRelativeToSetting
    {
        // Summary:
        //     Indicates that a service definition is relative to the current context.The
        //     current context refers to the relative path of the collection or application
        //     that the ServiceDefinition belongs to. For a ServiceDefinition to have a
        //     RelativeToSetting of Context its RelativePath property must not be null or
        //     empty.
        Context = 0,
        //
        // Summary:
        //     Indicates that a ServiceDefinition is relative to the web application.For
        //     a ServiceDefinition to have a RelativeToSetting of WebApplication, its RelativePath
        //     property must not be null or empty.
        WebApplication = 2,
        //
        // Summary:
        //     Indicates that a ServiceDefinition is not relative to anything. For a ServiceDefinition
        //     to have a RelativeToSetting of FullyQualified, its RelativePath property
        //     must be null.
        FullyQualified = 3,
    }
}