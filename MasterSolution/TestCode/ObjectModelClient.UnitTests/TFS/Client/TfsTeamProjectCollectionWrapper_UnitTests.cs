using System;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class TfsTeamProjectCollectionWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref TfsTeamProjectCollection real,  string callerName)
        {
            real = GetRealInstance();
        }

        /// <summary>
        /// Gets the real instance.
        /// </summary>
        /// <returns>TfsTeamProjectCollection.</returns>
        public static TfsTeamProjectCollection GetRealInstance()
        {
            var uri = new Uri("http://localhost:8080/tfs");
            return new TfsTeamProjectCollection(uri);            
        }
    }
}