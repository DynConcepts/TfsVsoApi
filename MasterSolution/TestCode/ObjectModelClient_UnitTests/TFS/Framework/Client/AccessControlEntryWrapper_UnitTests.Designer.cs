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
    public partial class AccessControlEntryWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Allow_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlEntry) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    Allow_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Allow = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Allow; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Deny_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlEntry) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    Deny_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Deny = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Deny; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ExtendedInfo_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlEntry) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IAceExtendedInformation setValue = default(IAceExtendedInformation);
                    ExtendedInfo_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ExtendedInfo = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ExtendedInfo; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Allow_SetCondition(ref IAccessControlEntry instance, ref Int32 setValue);
        partial void Deny_SetCondition(ref IAccessControlEntry instance, ref Int32 setValue);
        partial void ExtendedInfo_SetCondition(ref IAccessControlEntry instance, ref IAceExtendedInformation setValue);
        internal static IEnumerable<AccessControlEntryWrapper> GetIEnumerableInstance() { return new List<AccessControlEntryWrapper> {GetInstance()}; }

        internal static AccessControlEntryWrapper GetInstance()
        {
            AccessControlEntry real = default(AccessControlEntry);
            RealInstanceFactory(ref real);
            var instance = (AccessControlEntryWrapper) AccessControlEntryWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref AccessControlEntryWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref AccessControlEntry real, [CallerMemberName] string callerName = "");
    }
}