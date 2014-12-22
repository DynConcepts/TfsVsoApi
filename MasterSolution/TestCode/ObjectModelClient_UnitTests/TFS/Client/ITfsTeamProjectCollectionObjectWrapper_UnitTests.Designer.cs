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
    public partial class ITfsTeamProjectCollectionObjectWrapper_UnitTests : DynTestClassBase
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
                    projectCollection = TfsTeamProjectCollectionWrapper_UnitTests.GetInstance();
                    Initialize_PreCondition(ref instance, ref projectCollection);
                },
                instance => { instance.Initialize(projectCollection); },
                instance => { Initialize_PostValidate(instance, projectCollection); });
        }

        internal static IEnumerable<ITfsTeamProjectCollectionObjectWrapper> GetIEnumerableInstance() { return new List<ITfsTeamProjectCollectionObjectWrapper> {GetInstance()}; }

        internal static ITfsTeamProjectCollectionObjectWrapper GetInstance()
        {
            ITfsTeamProjectCollectionObject real = default(ITfsTeamProjectCollectionObject);
            RealInstanceFactory(ref real);
            var instance = (ITfsTeamProjectCollectionObjectWrapper) ITfsTeamProjectCollectionObjectWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void Initialize_PostValidate(IITfsTeamProjectCollectionObject instance, ITfsTeamProjectCollection projectCollection);
        partial void Initialize_PreCondition(ref IITfsTeamProjectCollectionObject instance, ref ITfsTeamProjectCollection projectCollection);
        static partial void InstanceFactory(ref ITfsTeamProjectCollectionObjectWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref ITfsTeamProjectCollectionObject real, [CallerMemberName] string callerName = "");
    }
}