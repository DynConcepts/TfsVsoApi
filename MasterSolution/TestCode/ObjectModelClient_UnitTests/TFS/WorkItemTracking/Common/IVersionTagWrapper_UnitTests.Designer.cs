using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Common
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IVersionTagWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void VersionTag_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIVersionTag) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.VersionTag; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<IVersionTagWrapper> GetIEnumerableInstance() { return new List<IVersionTagWrapper> {GetInstance()}; }

        internal static IVersionTagWrapper GetInstance()
        {
            IVersionTag real = default(IVersionTag);
            RealInstanceFactory(ref real);
            var instance = (IVersionTagWrapper) IVersionTagWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IVersionTagWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref IVersionTag real, [CallerMemberName] string callerName = "");

        partial void VersionTag_SetCondition(ref IIVersionTag instance, ref Int32 setValue);
    }
}