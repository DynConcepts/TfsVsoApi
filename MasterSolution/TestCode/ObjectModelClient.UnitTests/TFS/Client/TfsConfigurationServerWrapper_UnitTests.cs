using System;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class TfsConfigurationServerWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref TfsConfigurationServer real, string callerName)
        {
            var uri = new Uri("http://localhost:8080/tfs");
            real = new TfsConfigurationServer(uri);
        }
    }
}