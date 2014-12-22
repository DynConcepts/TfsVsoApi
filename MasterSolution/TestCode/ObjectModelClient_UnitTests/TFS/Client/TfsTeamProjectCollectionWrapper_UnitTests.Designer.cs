using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsTeamProjectCollectionWrapper_UnitTests : DynTestClassBase
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
        internal static IEnumerable<TfsTeamProjectCollectionWrapper> GetIEnumerableInstance() { return new List<TfsTeamProjectCollectionWrapper> {GetInstance()}; }

        internal static TfsTeamProjectCollectionWrapper GetInstance()
        {
            TfsTeamProjectCollection real = default(TfsTeamProjectCollection);
            RealInstanceFactory(ref real);
            var instance = (TfsTeamProjectCollectionWrapper) TfsTeamProjectCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref TfsTeamProjectCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref TfsTeamProjectCollection real, [CallerMemberName] string callerName = "");

        partial void TeamFoundationServer_SetCondition(ref ITfsTeamProjectCollection instance, ref ITeamFoundationServer setValue);
    }
}