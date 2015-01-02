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
    public partial class ILocationServiceImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ClientAccessMapping_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IILocationService) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ClientAccessMapping; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ConfigureAccessMapping_UnitTest()
        {
            String moniker = default(String);
            String displayName = default(String);
            String accessPoint = default(String);
            Boolean makeDefault = default(Boolean);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    moniker = default(String); //No Constructor
                    displayName = default(String); //No Constructor
                    accessPoint = default(String); //No Constructor
                    makeDefault = default(Boolean); //No Constructor
                    ConfigureAccessMapping_PreCondition(ref instance, ref moniker, ref displayName, ref accessPoint, ref makeDefault);
                },
                instance => { instance.ConfigureAccessMapping(moniker, displayName, accessPoint, makeDefault); },
                instance => { ConfigureAccessMapping_PostValidate(instance, moniker, displayName, accessPoint, makeDefault); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ConfiguredAccessMappings_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IILocationService) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ConfiguredAccessMappings; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DefaultAccessMapping_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IILocationService) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DefaultAccessMapping; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FindServiceDefinition_UnitTest()
        {
            String serviceType = default(String);
            Guid serviceIdentifier = default(Guid);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    serviceType = default(String); //No Constructor
                    serviceIdentifier = default(Guid); //No Constructor
                    FindServiceDefinition_PreCondition(ref instance, ref serviceType, ref serviceIdentifier);
                },
                instance => { instance.FindServiceDefinition(serviceType, serviceIdentifier); },
                instance => { FindServiceDefinition_PostValidate(instance, serviceType, serviceIdentifier); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FindServiceDefinitionsByToolType_UnitTest()
        {
            String toolType = default(String);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    toolType = default(String); //No Constructor
                    FindServiceDefinitionsByToolType_PreCondition(ref instance, ref toolType);
                },
                instance => { instance.FindServiceDefinitionsByToolType(toolType); },
                instance => { FindServiceDefinitionsByToolType_PostValidate(instance, toolType); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FindServiceDefinitions_UnitTest()
        {
            String serviceType = default(String);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    serviceType = default(String); //No Constructor
                    FindServiceDefinitions_PreCondition(ref instance, ref serviceType);
                },
                instance => { instance.FindServiceDefinitions(serviceType); },
                instance => { FindServiceDefinitions_PostValidate(instance, serviceType); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAccessMapping_UnitTest()
        {
            String moniker = default(String);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    moniker = default(String); //No Constructor
                    GetAccessMapping_PreCondition(ref instance, ref moniker);
                },
                instance => { instance.GetAccessMapping(moniker); },
                instance => { GetAccessMapping_PostValidate(instance, moniker); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LocationForAccessMapping_UnitTest()
        {
            String serviceType = default(String);
            Guid serviceIdentifier = default(Guid);
            IAccessMapping accessMapping = default(IAccessMapping);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    serviceType = default(String); //No Constructor
                    serviceIdentifier = default(Guid); //No Constructor
                    accessMapping = AccessMappingImpl_UnitTests.GetInstance();
                    LocationForAccessMapping_PreCondition(ref instance, ref serviceType, ref serviceIdentifier, ref accessMapping);
                },
                instance => { instance.LocationForAccessMapping(serviceType, serviceIdentifier, accessMapping); },
                instance => { LocationForAccessMapping_PostValidate(instance, serviceType, serviceIdentifier, accessMapping); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LocationForCurrentConnection_UnitTest()
        {
            String serviceType = default(String);
            Guid serviceIdentifier = default(Guid);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    serviceType = default(String); //No Constructor
                    serviceIdentifier = default(Guid); //No Constructor
                    LocationForCurrentConnection_PreCondition(ref instance, ref serviceType, ref serviceIdentifier);
                },
                instance => { instance.LocationForCurrentConnection(serviceType, serviceIdentifier); },
                instance => { LocationForCurrentConnection_PostValidate(instance, serviceType, serviceIdentifier); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveAccessMapping_UnitTest()
        {
            String moniker = default(String);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    moniker = default(String); //No Constructor
                    RemoveAccessMapping_PreCondition(ref instance, ref moniker);
                },
                instance => { instance.RemoveAccessMapping(moniker); },
                instance => { RemoveAccessMapping_PostValidate(instance, moniker); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveServiceDefinition_UnitTest()
        {
            String serviceType = default(String);
            Guid serviceIdentifier = default(Guid);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    serviceType = default(String); //No Constructor
                    serviceIdentifier = default(Guid); //No Constructor
                    RemoveServiceDefinition_PreCondition(ref instance, ref serviceType, ref serviceIdentifier);
                },
                instance => { instance.RemoveServiceDefinition(serviceType, serviceIdentifier); },
                instance => { RemoveServiceDefinition_PostValidate(instance, serviceType, serviceIdentifier); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveServiceDefinitions_UnitTest()
        {
            IEnumerable<IServiceDefinition> serviceDefinitions = default(IEnumerable<IServiceDefinition>);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    serviceDefinitions = ServiceDefinitionImpl_UnitTests.GetIEnumerableInstance();
                    RemoveServiceDefinitions_PreCondition(ref instance, ref serviceDefinitions);
                },
                instance => { instance.RemoveServiceDefinitions(serviceDefinitions); },
                instance => { RemoveServiceDefinitions_PostValidate(instance, serviceDefinitions); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SaveServiceDefinition_UnitTest()
        {
            IServiceDefinition serviceDefinition = default(IServiceDefinition);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    serviceDefinition = ServiceDefinitionImpl_UnitTests.GetInstance();
                    SaveServiceDefinition_PreCondition(ref instance, ref serviceDefinition);
                },
                instance => { instance.SaveServiceDefinition(serviceDefinition); },
                instance => { SaveServiceDefinition_PostValidate(instance, serviceDefinition); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SaveServiceDefinitions_UnitTest()
        {
            IEnumerable<IServiceDefinition> serviceDefinitions = default(IEnumerable<IServiceDefinition>);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    serviceDefinitions = ServiceDefinitionImpl_UnitTests.GetIEnumerableInstance();
                    SaveServiceDefinitions_PreCondition(ref instance, ref serviceDefinitions);
                },
                instance => { instance.SaveServiceDefinitions(serviceDefinitions); },
                instance => { SaveServiceDefinitions_PostValidate(instance, serviceDefinitions); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetDefaultAccessMapping_UnitTest()
        {
            IAccessMapping accessMapping = default(IAccessMapping);
            ExecuteMethod(
                () => { return (IILocationService) GetInstance(); },
                instance =>
                {
                    accessMapping = AccessMappingImpl_UnitTests.GetInstance();
                    SetDefaultAccessMapping_PreCondition(ref instance, ref accessMapping);
                },
                instance => { instance.SetDefaultAccessMapping(accessMapping); },
                instance => { SetDefaultAccessMapping_PostValidate(instance, accessMapping); });
        }

        partial void ClientAccessMapping_SetCondition(ref IILocationService instance, ref IAccessMapping setValue);
        partial void ConfigureAccessMapping_PostValidate(IILocationService instance, String moniker, String displayName, String accessPoint, Boolean makeDefault);
        partial void ConfigureAccessMapping_PreCondition(ref IILocationService instance, ref String moniker, ref String displayName, ref String accessPoint, ref Boolean makeDefault);

        partial void ConfiguredAccessMappings_SetCondition(ref IILocationService instance, ref IEnumerable<IAccessMapping> setValue);
        partial void DefaultAccessMapping_SetCondition(ref IILocationService instance, ref IAccessMapping setValue);
        partial void FindServiceDefinition_PostValidate(IILocationService instance, String serviceType, Guid serviceIdentifier);
        partial void FindServiceDefinition_PreCondition(ref IILocationService instance, ref String serviceType, ref Guid serviceIdentifier);
        partial void FindServiceDefinitionsByToolType_PostValidate(IILocationService instance, String toolType);
        partial void FindServiceDefinitionsByToolType_PreCondition(ref IILocationService instance, ref String toolType);
        partial void FindServiceDefinitions_PostValidate(IILocationService instance, String serviceType);
        partial void FindServiceDefinitions_PreCondition(ref IILocationService instance, ref String serviceType);
        partial void GetAccessMapping_PostValidate(IILocationService instance, String moniker);
        partial void GetAccessMapping_PreCondition(ref IILocationService instance, ref String moniker);
        internal static IEnumerable<ILocationServiceImpl> GetIEnumerableInstance() { return new List<ILocationServiceImpl> {GetInstance()}; }

        internal static ILocationServiceImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ILocationServiceImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ILocationServiceImpl instance, [CallerMemberName] string callerName = "");
        partial void LocationForAccessMapping_PostValidate(IILocationService instance, String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping);
        partial void LocationForAccessMapping_PreCondition(ref IILocationService instance, ref String serviceType, ref Guid serviceIdentifier, ref IAccessMapping accessMapping);
        partial void LocationForCurrentConnection_PostValidate(IILocationService instance, String serviceType, Guid serviceIdentifier);
        partial void LocationForCurrentConnection_PreCondition(ref IILocationService instance, ref String serviceType, ref Guid serviceIdentifier);
        partial void RemoveAccessMapping_PostValidate(IILocationService instance, String moniker);
        partial void RemoveAccessMapping_PreCondition(ref IILocationService instance, ref String moniker);
        partial void RemoveServiceDefinition_PostValidate(IILocationService instance, String serviceType, Guid serviceIdentifier);
        partial void RemoveServiceDefinition_PreCondition(ref IILocationService instance, ref String serviceType, ref Guid serviceIdentifier);
        partial void RemoveServiceDefinitions_PostValidate(IILocationService instance, IEnumerable<IServiceDefinition> serviceDefinitions);
        partial void RemoveServiceDefinitions_PreCondition(ref IILocationService instance, ref IEnumerable<IServiceDefinition> serviceDefinitions);
        partial void SaveServiceDefinition_PostValidate(IILocationService instance, IServiceDefinition serviceDefinition);
        partial void SaveServiceDefinition_PreCondition(ref IILocationService instance, ref IServiceDefinition serviceDefinition);
        partial void SaveServiceDefinitions_PostValidate(IILocationService instance, IEnumerable<IServiceDefinition> serviceDefinitions);
        partial void SaveServiceDefinitions_PreCondition(ref IILocationService instance, ref IEnumerable<IServiceDefinition> serviceDefinitions);
        partial void SetDefaultAccessMapping_PostValidate(IILocationService instance, IAccessMapping accessMapping);
        partial void SetDefaultAccessMapping_PreCondition(ref IILocationService instance, ref IAccessMapping accessMapping);
    }
}