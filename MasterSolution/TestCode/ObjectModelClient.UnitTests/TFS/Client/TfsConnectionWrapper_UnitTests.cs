using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Client.Channels;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class TfsConnectionWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref TfsConnection real, string callerName)
        {
            real = GetRealInstance();
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "ClientCredentials_UnitTest",
            "GetClient_UnitTest",
            "TimeZone_UnitTest",
            "UICulture_UnitTest"
        };

        /// <summary>
        /// Gets the real instance.
        /// </summary>
        /// <returns>CatalogResource.</returns>
        public static TfsConnection GetRealInstance()
        {
            var uri = new Uri("http://localhost:8080/tfs");
            return new TfsConfigurationServer(uri);
        }
    }
}