using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RegisteredLinkTypeImpl_UnitTests : DynTestClassBase
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
        internal static IEnumerable<RegisteredLinkTypeImpl> GetIEnumerableInstance() { return new List<RegisteredLinkTypeImpl> {GetInstance()}; }

        internal static RegisteredLinkTypeImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new RegisteredLinkTypeImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref RegisteredLinkTypeImpl instance, [CallerMemberName] string callerName = "");
    }
}