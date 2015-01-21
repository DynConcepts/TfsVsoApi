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
    public partial class FieldCollectionWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DropCachedData_UnitTest()
        {
            ExecuteMethod(
                () => { return (IFieldCollection) GetInstance(); },
                instance => { DropCachedData_PreCondition(instance); },
                instance => { instance.DropCachedData(); },
                instance => { DropCachedData_PostValidate(instance); });
        }

        partial void DropCachedData_PostValidate(IFieldCollection instance);
        partial void DropCachedData_PreCondition(IFieldCollection instance);
        internal static IEnumerable<FieldCollectionWrapper> GetIEnumerableInstance() { return new List<FieldCollectionWrapper> {GetInstance()}; }

        internal static FieldCollectionWrapper GetInstance()
        {
            FieldCollection real = default(FieldCollection);
            RealInstanceFactory(ref real);
            var instance = (FieldCollectionWrapper) FieldCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref FieldCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref FieldCollection real, [CallerMemberName] string callerName = "");
    }
}