using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ILocationServiceWrapper_UnitTests
    {
        partial void ConfigureAccessMapping_PreCondition(IILocationService instance, ref String moniker, ref String displayName, ref String accessPoint, ref Boolean makeDefault) { moniker = "TestMoniker"; }

        internal static ILocationService GetRealInstance()
        {
            CredentialsStore credentials = CredentialsProvider.Read(@"..\..\..\RestCredentials.xml");
            var uri = new Uri(credentials.VsoCollection);
            var tpc = new TfsTeamProjectCollection(uri);
            var real = tpc.GetService<ILocationService>();
            return real;
        }

        static partial void RealInstanceFactory(ref ILocationService real, string callerName) { real = GetRealInstance(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "ConfigureAccessMapping_UnitTest",
            "GetAccessMapping_UnitTest",
            "FindServiceDefinition_UnitTest",
            "LocationForCurrentConnection_UnitTest",
            "RemoveAccessMapping_UnitTest",
            "RemoveServiceDefinition_UnitTest",
            "LocationForAccessMapping_UnitTest",
            "RemoveServiceDefinitions_UnitTest",
            "SaveServiceDefinition_UnitTest",
            "SaveServiceDefinitions_UnitTest",
            "SetDefaultAccessMapping_UnitTest"
        };
    }
}