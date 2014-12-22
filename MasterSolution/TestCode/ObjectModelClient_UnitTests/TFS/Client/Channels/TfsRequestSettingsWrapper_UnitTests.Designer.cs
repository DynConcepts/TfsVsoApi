using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsRequestSettingsWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AgentId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    AgentId_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.AgentId = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.AgentId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BypassProxyOnLocal_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    BypassProxyOnLocal_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.BypassProxyOnLocal = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.BypassProxyOnLocal; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Clone_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsRequestSettings) GetInstance(); },
                instance => { Clone_PreCondition(ref instance); },
                instance => { instance.Clone(); },
                instance => { Clone_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CompressRequestBody_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    CompressRequestBody_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.CompressRequestBody = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.CompressRequestBody; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CompressionEnabled_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    CompressionEnabled_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.CompressionEnabled = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.CompressionEnabled; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ConnectionLimit_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ConnectionLimit; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SendTimeout_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    TimeSpan setValue = default(TimeSpan);
                    SendTimeout_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.SendTimeout = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.SendTimeout; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SoapTraceEnabled_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SoapTraceEnabled; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Tracing_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Tracing; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UserAgent_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsRequestSettings) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.UserAgent; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AgentId_SetCondition(ref ITfsRequestSettings instance, ref String setValue);
        partial void BypassProxyOnLocal_SetCondition(ref ITfsRequestSettings instance, ref Boolean setValue);
        partial void Clone_PostValidate(ITfsRequestSettings instance);
        partial void Clone_PreCondition(ref ITfsRequestSettings instance);
        partial void CompressRequestBody_SetCondition(ref ITfsRequestSettings instance, ref Boolean setValue);
        partial void CompressionEnabled_SetCondition(ref ITfsRequestSettings instance, ref Boolean setValue);
        partial void ConnectionLimit_SetCondition(ref ITfsRequestSettings instance, ref Int32 setValue);
        internal static IEnumerable<TfsRequestSettingsWrapper> GetIEnumerableInstance() { return new List<TfsRequestSettingsWrapper> {GetInstance()}; }

        internal static TfsRequestSettingsWrapper GetInstance()
        {
            var real = new TfsRequestSettings();
            RealInstanceFactory(ref real);
            var instance = (TfsRequestSettingsWrapper) TfsRequestSettingsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref TfsRequestSettingsWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref TfsRequestSettings real, [CallerMemberName] string callerName = "");
        partial void SendTimeout_SetCondition(ref ITfsRequestSettings instance, ref TimeSpan setValue);
        partial void SoapTraceEnabled_SetCondition(ref ITfsRequestSettings instance, ref Boolean setValue);
        partial void Tracing_SetCondition(ref ITfsRequestSettings instance, ref TraceSwitch setValue);
        partial void UserAgent_SetCondition(ref ITfsRequestSettings instance, ref String setValue);
    }
}