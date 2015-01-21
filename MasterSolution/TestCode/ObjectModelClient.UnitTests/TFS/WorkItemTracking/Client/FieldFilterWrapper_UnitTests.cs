using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class FieldFilterWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref FieldFilter real, string callerName)
        {
            FieldDefinition fd = (FieldDefinition) FormatterServices.GetUninitializedObject(typeof(FieldDefinition)); 
            object value = null;
            real = new FieldFilter(fd, value); 
        }
    }
}