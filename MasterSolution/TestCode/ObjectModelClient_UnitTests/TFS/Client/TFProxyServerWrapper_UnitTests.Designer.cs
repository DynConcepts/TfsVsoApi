using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TFProxyServerWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsAvailable_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITFProxyServer) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsAvailable; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsEnabled_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITFProxyServer) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    IsEnabled_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.IsEnabled = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.IsEnabled; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LastConfigureTime_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITFProxyServer) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    DateTime setValue = default(DateTime);
                    LastConfigureTime_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.LastConfigureTime = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.LastConfigureTime; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void NotifyUnavailable_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITFProxyServer) GetInstance(); },
                instance => { NotifyUnavailable_PreCondition(ref instance); },
                instance => { instance.NotifyUnavailable(); },
                instance => { NotifyUnavailable_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Url_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITFProxyServer) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Url_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Url = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Url; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WasAutoConfigured_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITFProxyServer) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    WasAutoConfigured_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.WasAutoConfigured = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.WasAutoConfigured; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<TFProxyServerWrapper> GetIEnumerableInstance() { return new List<TFProxyServerWrapper> {GetInstance()}; }

        internal static TFProxyServerWrapper GetInstance()
        {
            TFProxyServer real = default(TFProxyServer);
            RealInstanceFactory(ref real);
            var instance = (TFProxyServerWrapper) TFProxyServerWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref TFProxyServerWrapper instance, [CallerMemberName] string callerName = "");
        partial void IsAvailable_SetCondition(ref ITFProxyServer instance, ref Boolean setValue);
        partial void IsEnabled_SetCondition(ref ITFProxyServer instance, ref Boolean setValue);

        partial void LastConfigureTime_SetCondition(ref ITFProxyServer instance, ref DateTime setValue);
        partial void NotifyUnavailable_PostValidate(ITFProxyServer instance);
        partial void NotifyUnavailable_PreCondition(ref ITFProxyServer instance);
        static partial void RealInstanceFactory(ref TFProxyServer real, [CallerMemberName] string callerName = "");
        partial void Url_SetCondition(ref ITFProxyServer instance, ref String setValue);
        partial void WasAutoConfigured_SetCondition(ref ITFProxyServer instance, ref Boolean setValue);
    }
}