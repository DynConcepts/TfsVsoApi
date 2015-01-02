using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class StoredQueryWrapper_UnitTests
    {
        const string Wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
        static partial void RealInstanceFactory(ref StoredQuery real, string callerName)
        {
            real = new StoredQuery(QueryScope.Private, "My Query", Wiql, "My Description");
        }

        partial void QueryText_SetCondition(ref IStoredQuery instance, ref String setValue) { setValue = Wiql; }

    }
}