using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AccessMappingWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AccessPoint_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessMapping) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AccessPoint; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Moniker_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessMapping) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Moniker; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AccessPoint_SetCondition(ref IAccessMapping instance, ref String setValue);
        internal static IEnumerable<AccessMappingWrapper> GetIEnumerableInstance() { return new List<AccessMappingWrapper> {GetInstance()}; }

        internal static AccessMappingWrapper GetInstance()
        {
            AccessMapping real = default(AccessMapping);
            RealInstanceFactory(ref real);
            var instance = (AccessMappingWrapper) AccessMappingWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref AccessMappingWrapper instance, [CallerMemberName] string callerName = "");
        partial void Moniker_SetCondition(ref IAccessMapping instance, ref String setValue);
        static partial void RealInstanceFactory(ref AccessMapping real, [CallerMemberName] string callerName = "");
    }
}