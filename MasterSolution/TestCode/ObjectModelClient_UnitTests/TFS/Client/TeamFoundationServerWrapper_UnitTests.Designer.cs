using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TeamFoundationServerWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AuthenticatedUserDisplayName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationServer) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AuthenticatedUserDisplayName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AuthenticatedUserIdentity_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationServer) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AuthenticatedUserIdentity; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AuthenticatedUserName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationServer) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AuthenticatedUserName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TfsTeamProjectCollection_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationServer) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.TfsTeamProjectCollection; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AuthenticatedUserDisplayName_SetCondition(ref ITeamFoundationServer instance, ref String setValue);

        partial void AuthenticatedUserIdentity_SetCondition(ref ITeamFoundationServer instance, ref IIdentity setValue);
        partial void AuthenticatedUserName_SetCondition(ref ITeamFoundationServer instance, ref String setValue);
        internal static IEnumerable<TeamFoundationServerWrapper> GetIEnumerableInstance() { return new List<TeamFoundationServerWrapper> {GetInstance()}; }

        internal static TeamFoundationServerWrapper GetInstance()
        {
            TeamFoundationServer real = default(TeamFoundationServer);
            RealInstanceFactory(ref real);
            var instance = (TeamFoundationServerWrapper) TeamFoundationServerWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref TeamFoundationServerWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref TeamFoundationServer real, [CallerMemberName] string callerName = "");

        partial void TfsTeamProjectCollection_SetCondition(ref ITeamFoundationServer instance, ref ITfsTeamProjectCollection setValue);
    }
}