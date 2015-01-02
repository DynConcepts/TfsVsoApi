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
    public partial class LocationMappingImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AccessMapping_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILocationMapping) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AccessMapping; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Location_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILocationMapping) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Location; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AccessMapping_SetCondition(ref ILocationMapping instance, ref IAccessMapping setValue);
        internal static IEnumerable<LocationMappingImpl> GetIEnumerableInstance() { return new List<LocationMappingImpl> {GetInstance()}; }

        internal static LocationMappingImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new LocationMappingImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref LocationMappingImpl instance, [CallerMemberName] string callerName = "");
        partial void Location_SetCondition(ref ILocationMapping instance, ref String setValue);
    }
}