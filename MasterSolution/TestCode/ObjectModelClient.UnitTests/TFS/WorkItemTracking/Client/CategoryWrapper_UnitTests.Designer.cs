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
    public partial class CategoryWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DefaultWorkItemType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICategory) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DefaultWorkItemType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WorkItemTypes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICategory) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItemTypes; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void DefaultWorkItemType_SetCondition(ref ICategory instance, ref IWorkItemType setValue);
        internal static IEnumerable<CategoryWrapper> GetIEnumerableInstance() { return new List<CategoryWrapper> {GetInstance()}; }

        internal static CategoryWrapper GetInstance()
        {
            Category real = default(Category);
            RealInstanceFactory(ref real);
            var instance = (CategoryWrapper) CategoryWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref CategoryWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref Category real, [CallerMemberName] string callerName = "");

        partial void WorkItemTypes_SetCondition(ref ICategory instance, ref IEnumerable<IWorkItemType> setValue);
    }
}