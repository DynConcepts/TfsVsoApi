using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class TeamFoundationIdentityWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref TeamFoundationIdentity real, string callerName)
        {
            var tfs = TfsTeamProjectCollectionWrapper_UnitTests.GetRealInstance();
            var ims = tfs.GetService<IIdentityManagementService>();
            TeamFoundationIdentity userId = ims.ReadIdentity(IdentitySearchFactor.DisplayName, "David Corbin", MembershipQuery.Direct, ReadIdentityOptions.None);
            real = userId;
        }

        partial void GetProperty_PreCondition(ITeamFoundationIdentity instance, ref String name) { name = "Account"; }

        partial void SetProperty_PreCondition(ITeamFoundationIdentity instance, ref String name, ref Object value)
        {
            name = "TestingProperty";
            value = "TestingValue";
        }

        partial void SetProperty_PostValidate(ITeamFoundationIdentity instance, String name, Object value)
        {
            instance.RemoveProperty(IIdentityPropertyScope.Local, name);
        }

        partial void RemoveProperty_PreCondition(ITeamFoundationIdentity instance, ref String name)
        {
            name = "TestingProperty";
            var value = "TestingValue";
            instance.SetProperty(name,value);
           
        }
        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetAttribute_UnitTest",
            "Members_UnitTest",
            "MemberOf_UnitTest",
            "SetAttribute_UnitTest",
            "TryGetProperty_UnitTest"
        };
    }
}