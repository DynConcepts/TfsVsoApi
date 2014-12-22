using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AceExtendedInformationImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EffectiveAllow_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAceExtendedInformation) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.EffectiveAllow; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EffectiveDeny_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAceExtendedInformation) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.EffectiveDeny; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void InheritedAllow_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAceExtendedInformation) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.InheritedAllow; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void InheritedDeny_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAceExtendedInformation) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.InheritedDeny; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void EffectiveAllow_SetCondition(ref IAceExtendedInformation instance, ref Int32 setValue);

        partial void EffectiveDeny_SetCondition(ref IAceExtendedInformation instance, ref Int32 setValue);
        internal static IEnumerable<AceExtendedInformationImpl> GetIEnumerableInstance() { return new List<AceExtendedInformationImpl> {GetInstance()}; }

        internal static AceExtendedInformationImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new AceExtendedInformationImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void InheritedAllow_SetCondition(ref IAceExtendedInformation instance, ref Int32 setValue);
        partial void InheritedDeny_SetCondition(ref IAceExtendedInformation instance, ref Int32 setValue);
        static partial void InstanceFactory(ref AceExtendedInformationImpl instance, [CallerMemberName] string callerName = "");
    }
}