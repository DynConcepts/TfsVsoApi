using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TeamFoundationServerImpl_UnitTests : DynTestClassBase
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
        internal static IEnumerable<TeamFoundationServerImpl> GetIEnumerableInstance() { return new List<TeamFoundationServerImpl> {GetInstance()}; }

        internal static TeamFoundationServerImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TeamFoundationServerImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref TeamFoundationServerImpl instance, [CallerMemberName] string callerName = "");

        partial void TfsTeamProjectCollection_SetCondition(ref ITeamFoundationServer instance, ref ITfsTeamProjectCollection setValue);
    }
}