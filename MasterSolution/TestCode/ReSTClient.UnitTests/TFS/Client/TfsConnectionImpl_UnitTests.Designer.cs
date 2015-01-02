using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsConnectionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CatalogNode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CatalogNode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChannelFactory_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ChannelFactory; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ClientCredentials_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    ITfsClientCredentials setValue = default(ITfsClientCredentials);
                    ClientCredentials_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ClientCredentials = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ClientCredentials; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ConnectivityFailureOnLastWebServiceCall_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ConnectivityFailureOnLastWebServiceCall; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Dispose_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsConnection) GetInstance(); },
                instance => { Dispose_PreCondition(ref instance); },
                instance => { instance.Dispose(); },
                instance => { Dispose_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Disposed_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Disposed; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FlushServices_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsConnection) GetInstance(); },
                instance => { FlushServices_PreCondition(ref instance); },
                instance => { instance.FlushServices(); },
                instance => { FlushServices_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAuthenticatedIdentity_UnitTest()
        {
            ITeamFoundationIdentity identity = default(ITeamFoundationIdentity);
            ExecuteMethod(
                () => { return (ITfsConnection) GetInstance(); },
                instance =>
                {
                    identity = TeamFoundationIdentityImpl_UnitTests.GetInstance();
                    GetAuthenticatedIdentity_PreCondition(ref instance, ref identity);
                },
                instance => { instance.GetAuthenticatedIdentity(out identity); },
                instance => { GetAuthenticatedIdentity_PostValidate(instance, identity); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetClient_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsConnection) GetInstance(); },
                instance => { GetClient_PreCondition(ref instance); },
                instance => { instance.GetClient<object>(); },
                instance => { GetClient_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetService_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsConnection) GetInstance(); },
                instance => { GetService_PreCondition(ref instance); },
                instance => { instance.GetService<object>(); },
                instance => { GetService_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IdentityToImpersonate_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IdentityToImpersonate; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsHostedServer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsHostedServer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ProxyServer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ProxyServer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ServerDataProvider_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ServerDataProvider; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TimeZone_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    TimeZone setValue = default(TimeZone);
                    TimeZone_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.TimeZone = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.TimeZone; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UICulture_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsConnection) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    CultureInfo setValue = default(CultureInfo);
                    UICulture_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.UICulture = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.UICulture; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void CatalogNode_SetCondition(ref ITfsConnection instance, ref ICatalogNode setValue);
        partial void ChannelFactory_SetCondition(ref ITfsConnection instance, ref IITfsRequestChannelFactory setValue);
        partial void ClientCredentials_SetCondition(ref ITfsConnection instance, ref ITfsClientCredentials setValue);

        partial void ConnectivityFailureOnLastWebServiceCall_SetCondition(ref ITfsConnection instance, ref Boolean setValue);
        partial void Dispose_PostValidate(ITfsConnection instance);
        partial void Dispose_PreCondition(ref ITfsConnection instance);

        partial void Disposed_SetCondition(ref ITfsConnection instance, ref Boolean setValue);
        partial void FlushServices_PostValidate(ITfsConnection instance);
        partial void FlushServices_PreCondition(ref ITfsConnection instance);
        partial void GetAuthenticatedIdentity_PostValidate(ITfsConnection instance, ITeamFoundationIdentity identity);
        partial void GetAuthenticatedIdentity_PreCondition(ref ITfsConnection instance, ref ITeamFoundationIdentity identity);
        partial void GetClient_PostValidate(ITfsConnection instance);
        partial void GetClient_PreCondition(ref ITfsConnection instance);
        internal static IEnumerable<TfsConnectionImpl> GetIEnumerableInstance() { return new List<TfsConnectionImpl> {GetInstance()}; }

        internal static TfsConnectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TfsConnectionImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetService_PostValidate(ITfsConnection instance);
        partial void GetService_PreCondition(ref ITfsConnection instance);
        partial void IdentityToImpersonate_SetCondition(ref ITfsConnection instance, ref IIdentityDescriptor setValue);
        static partial void InstanceFactory(ref TfsConnectionImpl instance, [CallerMemberName] string callerName = "");
        partial void IsHostedServer_SetCondition(ref ITfsConnection instance, ref Boolean setValue);
        partial void ProxyServer_SetCondition(ref ITfsConnection instance, ref ITFProxyServer setValue);

        partial void ServerDataProvider_SetCondition(ref ITfsConnection instance, ref IIServerDataProvider setValue);
        partial void TimeZone_SetCondition(ref ITfsConnection instance, ref TimeZone setValue);
        partial void UICulture_SetCondition(ref ITfsConnection instance, ref CultureInfo setValue);
    }
}