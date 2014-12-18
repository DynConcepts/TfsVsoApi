using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
/// <summary>Generated Test Template</summary>
  public partial class ILocationServiceWrapper_UnitTests
  {
      static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Framework.Client.ILocationService real, string callerName) { real = GetRealInstance(); }

    internal static ILocationService GetRealInstance()
      {
          var uri = new Uri("*****");// TODO Put in appropriate value, then refactor
          var tpc = new TfsTeamProjectCollection(uri);
          var real = tpc.GetService<ILocationService>();
          return real;
      }

      private static readonly List<String> sr_DisabledTests = new List<string>()
      {
          "ConfigureAccessMapping_UnitTest",
          "GetAccessMapping_UnitTest",
          "FindServiceDefinition_UnitTest",
          "LocationForCurrentConnection_UnitTest",
          "RemoveAccessMapping_UnitTest",
          "RemoveServiceDefinition_UnitTest"
      };
      /// <summary>
      /// Gets the disabled tests.
      /// </summary>
      /// <value>The disabled tests.</value>
      protected override List<String> DisabledTests { get { return sr_DisabledTests; } } 


    partial void ConfigureAccessMapping_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService instance, ref System.String moniker, ref System.String displayName, ref System.String accessPoint, ref System.Boolean makeDefault) { moniker = "TestMoniker"; }

  }
}
