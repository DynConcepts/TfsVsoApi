using System;
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
    public partial class TfsConfigurationServerWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTeamProjectCollection_UnitTest()
        {
            Guid collectionId = default(Guid);
            ExecuteMethod(
                () => { return (ITfsConfigurationServer) GetInstance(); },
                instance =>
                {
                    collectionId = default(Guid); //No Constructor
                    GetTeamProjectCollection_PreCondition(instance, ref collectionId);
                },
                instance => { instance.GetTeamProjectCollection(collectionId); },
                instance => { GetTeamProjectCollection_PostValidate(instance, collectionId); });
        }

        internal static IEnumerable<TfsConfigurationServerWrapper> GetIEnumerableInstance() { return new List<TfsConfigurationServerWrapper> {GetInstance()}; }

        internal static TfsConfigurationServerWrapper GetInstance()
        {
            TfsConfigurationServer real = default(TfsConfigurationServer);
            RealInstanceFactory(ref real);
            var instance = (TfsConfigurationServerWrapper) TfsConfigurationServerWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetTeamProjectCollection_PostValidate(ITfsConfigurationServer instance, Guid collectionId);
        partial void GetTeamProjectCollection_PreCondition(ITfsConfigurationServer instance, ref Guid collectionId);
        static partial void InstanceFactory(ref TfsConfigurationServerWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref TfsConfigurationServer real, [CallerMemberName] string callerName = "");
    }
}