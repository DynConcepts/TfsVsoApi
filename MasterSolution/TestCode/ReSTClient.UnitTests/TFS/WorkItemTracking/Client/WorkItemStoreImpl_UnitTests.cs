using DynCon.OSI.VSO.ReSTClient.APIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class WorkItemStoreImpl_UnitTests
  {
      const string DefaultWiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
    partial void Query_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String wiql) 
    { 
        wiql =DefaultWiql;
    }

    partial void QueryCount_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String wiql)
    {
        wiql = DefaultWiql;
    }

    /// <summary>
    /// Class_s the initialize.
    /// </summary>
    /// <param name="context">The context.</param>
    [ClassInitialize]
    public static void Class_Initialize(TestContext context)
    {
        var api = new JsonWorkItemAPI();
    }

  }
}
