using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AccessMappingImpl_UnitTests : DynTestClassBase
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
        internal static IEnumerable<AccessMappingImpl> GetIEnumerableInstance() { return new List<AccessMappingImpl> {GetInstance()}; }

        internal static AccessMappingImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new AccessMappingImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref AccessMappingImpl instance, [CallerMemberName] string callerName = "");
        partial void Moniker_SetCondition(ref IAccessMapping instance, ref String setValue);
    }
}