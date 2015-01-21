using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class HyperlinkWrapper_UnitTests
    {
        /// <summary>
        /// Gets the real instance.
        /// </summary>
        /// <returns>Hyperlink.</returns>
        public static Hyperlink GetRealInstance() { return new Hyperlink("http://www.example.com"); }

        static partial void RealInstanceFactory(ref Hyperlink real, string callerName) { real = GetRealInstance(); }

    }
}