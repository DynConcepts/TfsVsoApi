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
    public partial class SortFieldWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SortType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ISortField) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SortType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<SortFieldWrapper> GetIEnumerableInstance() { return new List<SortFieldWrapper> {GetInstance()}; }

        internal static SortFieldWrapper GetInstance()
        {
            SortField real = default(SortField);
            RealInstanceFactory(ref real);
            var instance = (SortFieldWrapper) SortFieldWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref SortFieldWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref SortField real, [CallerMemberName] string callerName = "");

        partial void SortType_SetCondition(ref ISortField instance, ref ISortType setValue);
    }
}