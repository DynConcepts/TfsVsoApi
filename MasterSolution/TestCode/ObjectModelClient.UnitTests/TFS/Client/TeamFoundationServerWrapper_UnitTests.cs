using System;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class TeamFoundationServerWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref TeamFoundationServer real, string callerName)
        {
            var uri = new Uri("http://localhost:8080/tfs"); 
            real = new TeamFoundationServer(uri);
        }

    }
}