using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RegisteredLinkTypeWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Equals_UnitTest()
        {
            IRegisteredLinkType type = default(IRegisteredLinkType);
            ExecuteMethod(
                () => { return (IRegisteredLinkType) GetInstance(); },
                instance =>
                {
                    type = GetInstance();
                    Equals_PreCondition(ref instance, ref type);
                },
                instance => { instance.Equals(type); },
                instance => { Equals_PostValidate(instance, type); });
        }

        partial void Equals_PostValidate(IRegisteredLinkType instance, IRegisteredLinkType type);
        partial void Equals_PreCondition(ref IRegisteredLinkType instance, ref IRegisteredLinkType type);
        internal static IEnumerable<RegisteredLinkTypeWrapper> GetIEnumerableInstance() { return new List<RegisteredLinkTypeWrapper> {GetInstance()}; }

        internal static RegisteredLinkTypeWrapper GetInstance()
        {
            RegisteredLinkType real = default(RegisteredLinkType);
            RealInstanceFactory(ref real);
            var instance = (RegisteredLinkTypeWrapper) RegisteredLinkTypeWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref RegisteredLinkTypeWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref RegisteredLinkType real, [CallerMemberName] string callerName = "");
    }
}