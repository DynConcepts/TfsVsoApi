using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ServiceDefinitionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AddLocationMapping_UnitTest()
        {
            IAccessMapping accessMapping = default(IAccessMapping);
            String location = default(String);
            ExecuteMethod(
                () => { return (IServiceDefinition) GetInstance(); },
                instance =>
                {
                    accessMapping = AccessMappingImpl_UnitTests.GetInstance();
                    location = default(String); //No Constructor
                    AddLocationMapping_PreCondition(ref instance, ref accessMapping, ref location);
                },
                instance => { instance.AddLocationMapping(accessMapping, location); },
                instance => { AddLocationMapping_PostValidate(instance, accessMapping, location); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Description_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IServiceDefinition) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Description_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Description = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Description; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLocationMapping_UnitTest()
        {
            IAccessMapping accessMapping = default(IAccessMapping);
            ExecuteMethod(
                () => { return (IServiceDefinition) GetInstance(); },
                instance =>
                {
                    accessMapping = AccessMappingImpl_UnitTests.GetInstance();
                    GetLocationMapping_PreCondition(ref instance, ref accessMapping);
                },
                instance => { instance.GetLocationMapping(accessMapping); },
                instance => { GetLocationMapping_PostValidate(instance, accessMapping); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LocationMappings_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IServiceDefinition) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LocationMappings; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RelativePath_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IServiceDefinition) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    RelativePath_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.RelativePath = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.RelativePath; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RelativeToSetting_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IServiceDefinition) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IRelativeToSetting setValue = default(IRelativeToSetting);
                    RelativeToSetting_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.RelativeToSetting = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.RelativeToSetting; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveLocationMapping_UnitTest()
        {
            IAccessMapping accessMapping = default(IAccessMapping);
            ExecuteMethod(
                () => { return (IServiceDefinition) GetInstance(); },
                instance =>
                {
                    accessMapping = AccessMappingImpl_UnitTests.GetInstance();
                    RemoveLocationMapping_PreCondition(ref instance, ref accessMapping);
                },
                instance => { instance.RemoveLocationMapping(accessMapping); },
                instance => { RemoveLocationMapping_PostValidate(instance, accessMapping); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ServiceType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IServiceDefinition) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    ServiceType_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ServiceType = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ServiceType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToolType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IServiceDefinition) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    ToolType_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ToolType = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ToolType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AddLocationMapping_PostValidate(IServiceDefinition instance, IAccessMapping accessMapping, String location);
        partial void AddLocationMapping_PreCondition(ref IServiceDefinition instance, ref IAccessMapping accessMapping, ref String location);
        partial void Description_SetCondition(ref IServiceDefinition instance, ref String setValue);
        internal static IEnumerable<ServiceDefinitionImpl> GetIEnumerableInstance() { return new List<ServiceDefinitionImpl> {GetInstance()}; }

        internal static ServiceDefinitionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ServiceDefinitionImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetLocationMapping_PostValidate(IServiceDefinition instance, IAccessMapping accessMapping);
        partial void GetLocationMapping_PreCondition(ref IServiceDefinition instance, ref IAccessMapping accessMapping);
        static partial void InstanceFactory(ref ServiceDefinitionImpl instance, [CallerMemberName] string callerName = "");

        partial void LocationMappings_SetCondition(ref IServiceDefinition instance, ref IEnumerable<ILocationMapping> setValue);
        partial void RelativePath_SetCondition(ref IServiceDefinition instance, ref String setValue);
        partial void RelativeToSetting_SetCondition(ref IServiceDefinition instance, ref IRelativeToSetting setValue);
        partial void RemoveLocationMapping_PostValidate(IServiceDefinition instance, IAccessMapping accessMapping);
        partial void RemoveLocationMapping_PreCondition(ref IServiceDefinition instance, ref IAccessMapping accessMapping);
        partial void ServiceType_SetCondition(ref IServiceDefinition instance, ref String setValue);
        partial void ToolType_SetCondition(ref IServiceDefinition instance, ref String setValue);
    }
}