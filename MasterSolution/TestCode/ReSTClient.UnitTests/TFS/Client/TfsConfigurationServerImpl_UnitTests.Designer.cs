using System;
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
    public partial class TfsConfigurationServerImpl_UnitTests : DynTestClassBase
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
                    GetTeamProjectCollection_PreCondition(ref instance, ref collectionId);
                },
                instance => { instance.GetTeamProjectCollection(collectionId); },
                instance => { GetTeamProjectCollection_PostValidate(instance, collectionId); });
        }

        internal static IEnumerable<TfsConfigurationServerImpl> GetIEnumerableInstance() { return new List<TfsConfigurationServerImpl> {GetInstance()}; }

        internal static TfsConfigurationServerImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TfsConfigurationServerImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetTeamProjectCollection_PostValidate(ITfsConfigurationServer instance, Guid collectionId);
        partial void GetTeamProjectCollection_PreCondition(ref ITfsConfigurationServer instance, ref Guid collectionId);
        static partial void InstanceFactory(ref TfsConfigurationServerImpl instance, [CallerMemberName] string callerName = "");
    }
}