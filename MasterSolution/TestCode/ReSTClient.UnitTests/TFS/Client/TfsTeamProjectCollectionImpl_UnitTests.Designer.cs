using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsTeamProjectCollectionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ConfigurationServer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsTeamProjectCollection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ConfigurationServer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TeamFoundationServer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsTeamProjectCollection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.TeamFoundationServer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void ConfigurationServer_SetCondition(ref ITfsTeamProjectCollection instance, ref ITfsConfigurationServer setValue);
        internal static IEnumerable<TfsTeamProjectCollectionImpl> GetIEnumerableInstance() { return new List<TfsTeamProjectCollectionImpl> {GetInstance()}; }

        internal static TfsTeamProjectCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            TfsTeamProjectCollectionImpl instance = default(TfsTeamProjectCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref TfsTeamProjectCollectionImpl instance, [CallerMemberName] string callerName = "");
        partial void TeamFoundationServer_SetCondition(ref ITfsTeamProjectCollection instance, ref ITeamFoundationServer setValue);
    }
}