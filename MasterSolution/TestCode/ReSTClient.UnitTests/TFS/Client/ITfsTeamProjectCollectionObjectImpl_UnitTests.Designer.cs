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
    public partial class ITfsTeamProjectCollectionObjectImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Initialize_UnitTest()
        {
            ITfsTeamProjectCollection projectCollection = default(ITfsTeamProjectCollection);
            ExecuteMethod(
                () => { return (IITfsTeamProjectCollectionObject) GetInstance(); },
                instance =>
                {
                    projectCollection = TfsTeamProjectCollectionImpl_UnitTests.GetInstance();
                    Initialize_PreCondition(ref instance, ref projectCollection);
                },
                instance => { instance.Initialize(projectCollection); },
                instance => { Initialize_PostValidate(instance, projectCollection); });
        }

        internal static IEnumerable<ITfsTeamProjectCollectionObjectImpl> GetIEnumerableInstance() { return new List<ITfsTeamProjectCollectionObjectImpl> {GetInstance()}; }

        internal static ITfsTeamProjectCollectionObjectImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ITfsTeamProjectCollectionObjectImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void Initialize_PostValidate(IITfsTeamProjectCollectionObject instance, ITfsTeamProjectCollection projectCollection);
        partial void Initialize_PreCondition(ref IITfsTeamProjectCollectionObject instance, ref ITfsTeamProjectCollection projectCollection);
        static partial void InstanceFactory(ref ITfsTeamProjectCollectionObjectImpl instance, [CallerMemberName] string callerName = "");
    }
}