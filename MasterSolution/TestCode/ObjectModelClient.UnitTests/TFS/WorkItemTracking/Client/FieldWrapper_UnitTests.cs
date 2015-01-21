using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class FieldWrapper_UnitTests
    {
        internal static Field GetRealInstance()
        {
            Field real;
            FieldCollection collection = FieldCollectionWrapper_UnitTests.GetRealInstance();
            real = collection["Title"];
            return real;
        }

        static partial void RealInstanceFactory(ref Field real, string callerName) { real = GetRealInstance(); }
    }
}