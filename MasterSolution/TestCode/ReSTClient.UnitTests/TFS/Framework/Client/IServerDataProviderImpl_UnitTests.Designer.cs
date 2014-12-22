using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client;
using DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IServerDataProviderImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Authenticate_UnitTest()
        {
            ExecuteMethod(
                () => { return (IIServerDataProvider) GetInstance(); },
                instance => { Authenticate_PreCondition(ref instance); },
                instance => { instance.Authenticate(); },
                instance => { Authenticate_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AuthenticatedIdentity_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AuthenticatedIdentity; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AuthorizedIdentity_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AuthorizedIdentity; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CachedInstanceId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CachedInstanceId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CatalogResourceId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CatalogResourceId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ClientCacheDirectoryForInstance_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ClientCacheDirectoryForInstance; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ClientCacheDirectoryForUser_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ClientCacheDirectoryForUser; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ClientVolatileCacheDirectoryForInstance_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ClientVolatileCacheDirectoryForInstance; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Connect_UnitTest()
        {
            IConnectOptions connectOptions = default(IConnectOptions);
            ExecuteMethod(
                () => { return (IIServerDataProvider) GetInstance(); },
                instance =>
                {
                    connectOptions = ConnectOptionsImpl_UnitTests.GetInstance();
                    Connect_PreCondition(ref instance, ref connectOptions);
                },
                instance => { instance.Connect(connectOptions); },
                instance => { Connect_PostValidate(instance, connectOptions); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Disconnect_UnitTest()
        {
            ExecuteMethod(
                () => { return (IIServerDataProvider) GetInstance(); },
                instance => { Disconnect_PreCondition(ref instance); },
                instance => { instance.Disconnect(); },
                instance => { Disconnect_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void EnsureAuthenticated_UnitTest()
        {
            ExecuteMethod(
                () => { return (IIServerDataProvider) GetInstance(); },
                instance => { EnsureAuthenticated_PreCondition(ref instance); },
                instance => { instance.EnsureAuthenticated(); },
                instance => { EnsureAuthenticated_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FindServerLocation_UnitTest()
        {
            Guid serverGuid = default(Guid);
            ExecuteMethod(
                () => { return (IIServerDataProvider) GetInstance(); },
                instance =>
                {
                    serverGuid = default(Guid); //No Constructor
                    FindServerLocation_PreCondition(ref instance, ref serverGuid);
                },
                instance => { instance.FindServerLocation(serverGuid); },
                instance => { FindServerLocation_PostValidate(instance, serverGuid); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HasAuthenticated_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HasAuthenticated; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void InstanceId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.InstanceId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ReactToPossibleServerUpdate_UnitTest()
        {
            Int32 serverLastChangeId = default(Int32);
            ExecuteMethod(
                () => { return (IIServerDataProvider) GetInstance(); },
                instance =>
                {
                    serverLastChangeId = default(Int32); //No Constructor
                    ReactToPossibleServerUpdate_PreCondition(ref instance, ref serverLastChangeId);
                },
                instance => { instance.ReactToPossibleServerUpdate(serverLastChangeId); },
                instance => { ReactToPossibleServerUpdate_PostValidate(instance, serverLastChangeId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ServerCapabilities_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIServerDataProvider) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ServerCapabilities; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Authenticate_PostValidate(IIServerDataProvider instance);
        partial void Authenticate_PreCondition(ref IIServerDataProvider instance);
        partial void AuthenticatedIdentity_SetCondition(ref IIServerDataProvider instance, ref ITeamFoundationIdentity setValue);
        partial void AuthorizedIdentity_SetCondition(ref IIServerDataProvider instance, ref ITeamFoundationIdentity setValue);

        partial void CachedInstanceId_SetCondition(ref IIServerDataProvider instance, ref Guid setValue);

        partial void CatalogResourceId_SetCondition(ref IIServerDataProvider instance, ref Guid setValue);

        partial void ClientCacheDirectoryForInstance_SetCondition(ref IIServerDataProvider instance, ref String setValue);

        partial void ClientCacheDirectoryForUser_SetCondition(ref IIServerDataProvider instance, ref String setValue);
        partial void ClientVolatileCacheDirectoryForInstance_SetCondition(ref IIServerDataProvider instance, ref String setValue);
        partial void Connect_PostValidate(IIServerDataProvider instance, IConnectOptions connectOptions);
        partial void Connect_PreCondition(ref IIServerDataProvider instance, ref IConnectOptions connectOptions);
        partial void Disconnect_PostValidate(IIServerDataProvider instance);
        partial void Disconnect_PreCondition(ref IIServerDataProvider instance);
        partial void EnsureAuthenticated_PostValidate(IIServerDataProvider instance);
        partial void EnsureAuthenticated_PreCondition(ref IIServerDataProvider instance);
        partial void FindServerLocation_PostValidate(IIServerDataProvider instance, Guid serverGuid);
        partial void FindServerLocation_PreCondition(ref IIServerDataProvider instance, ref Guid serverGuid);
        internal static IEnumerable<IServerDataProviderImpl> GetIEnumerableInstance() { return new List<IServerDataProviderImpl> {GetInstance()}; }

        internal static IServerDataProviderImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IServerDataProviderImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void HasAuthenticated_SetCondition(ref IIServerDataProvider instance, ref Boolean setValue);
        static partial void InstanceFactory(ref IServerDataProviderImpl instance, [CallerMemberName] string callerName = "");
        partial void InstanceId_SetCondition(ref IIServerDataProvider instance, ref Guid setValue);
        partial void ReactToPossibleServerUpdate_PostValidate(IIServerDataProvider instance, Int32 serverLastChangeId);
        partial void ReactToPossibleServerUpdate_PreCondition(ref IIServerDataProvider instance, ref Int32 serverLastChangeId);
        partial void ServerCapabilities_SetCondition(ref IIServerDataProvider instance, ref IServerCapabilities setValue);
    }
}