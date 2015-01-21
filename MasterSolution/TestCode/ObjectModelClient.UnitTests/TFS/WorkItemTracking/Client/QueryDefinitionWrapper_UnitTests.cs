using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class QueryDefinitionWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref QueryDefinition real, string callerName)
        {
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            real = new QueryDefinition("MY Query", wiql);
        }

    }
}