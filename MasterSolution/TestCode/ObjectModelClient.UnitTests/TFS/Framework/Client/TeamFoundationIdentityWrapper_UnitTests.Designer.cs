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
    public partial class TeamFoundationIdentityWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Descriptor_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IIdentityDescriptor setValue = default(IIdentityDescriptor);
                    Descriptor_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Descriptor = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Descriptor; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DisplayName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    DisplayName_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.DisplayName = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.DisplayName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAttribute_UnitTest()
        {
            String name = default(String);
            String defaultValue = default(String);
            ExecuteMethod(
                () => { return (ITeamFoundationIdentity) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    defaultValue = default(String); //No Constructor
                    GetAttribute_PreCondition(instance, ref name, ref defaultValue);
                },
                instance => { instance.GetAttribute(name, defaultValue); },
                instance => { GetAttribute_PostValidate(instance, name, defaultValue); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProperties_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITeamFoundationIdentity) GetInstance(); },
                instance => { GetProperties_PreCondition(instance); },
                instance => { instance.GetProperties(); },
                instance => { GetProperties_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProperty_UnitTest()
        {
            String name = default(String);
            ExecuteMethod(
                () => { return (ITeamFoundationIdentity) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    GetProperty_PreCondition(instance, ref name);
                },
                instance => { instance.GetProperty(name); },
                instance => { GetProperty_PostValidate(instance, name); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsActive_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    IsActive_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.IsActive = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.IsActive; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsContainer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsContainer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void MemberOf_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IIdentityDescriptor[] setValue = default(IIdentityDescriptor[]);
                    MemberOf_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.MemberOf = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.MemberOf; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Members_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IIdentityDescriptor[] setValue = default(IIdentityDescriptor[]);
                    Members_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Members = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Members; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveProperty_UnitTest()
        {
            String name = default(String);
            ExecuteMethod(
                () => { return (ITeamFoundationIdentity) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    RemoveProperty_PreCondition(instance, ref name);
                },
                instance => { instance.RemoveProperty(name); },
                instance => { RemoveProperty_PostValidate(instance, name); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetAttribute_UnitTest()
        {
            String name = default(String);
            String value = default(String);
            ExecuteMethod(
                () => { return (ITeamFoundationIdentity) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    value = default(String); //No Constructor
                    SetAttribute_PreCondition(instance, ref name, ref value);
                },
                instance => { instance.SetAttribute(name, value); },
                instance => { SetAttribute_PostValidate(instance, name, value); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetProperty_UnitTest()
        {
            String name = default(String);
            Object value = default(Object);
            ExecuteMethod(
                () => { return (ITeamFoundationIdentity) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    value = new Object();
                    SetProperty_PreCondition(instance, ref name, ref value);
                },
                instance => { instance.SetProperty(name, value); },
                instance => { SetProperty_PostValidate(instance, name, value); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TeamFoundationId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    Guid setValue = default(Guid);
                    TeamFoundationId_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.TeamFoundationId = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.TeamFoundationId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TryGetProperty_UnitTest()
        {
            String name = default(String);
            Object value = default(Object);
            ExecuteMethod(
                () => { return (ITeamFoundationIdentity) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    value = new Object();
                    TryGetProperty_PreCondition(instance, ref name, ref value);
                },
                instance => { instance.TryGetProperty(name, out value); },
                instance => { TryGetProperty_PostValidate(instance, name, value); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UniqueName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.UniqueName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UniqueUserId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITeamFoundationIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    UniqueUserId_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.UniqueUserId = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.UniqueUserId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Descriptor_SetCondition(ref ITeamFoundationIdentity instance, ref IIdentityDescriptor setValue);

        partial void DisplayName_SetCondition(ref ITeamFoundationIdentity instance, ref String setValue);
        partial void GetAttribute_PostValidate(ITeamFoundationIdentity instance, String name, String defaultValue);
        partial void GetAttribute_PreCondition(ITeamFoundationIdentity instance, ref String name, ref String defaultValue);
        internal static IEnumerable<TeamFoundationIdentityWrapper> GetIEnumerableInstance() { return new List<TeamFoundationIdentityWrapper> {GetInstance()}; }

        internal static TeamFoundationIdentityWrapper GetInstance()
        {
            TeamFoundationIdentity real = default(TeamFoundationIdentity);
            RealInstanceFactory(ref real);
            var instance = (TeamFoundationIdentityWrapper) TeamFoundationIdentityWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetProperties_PostValidate(ITeamFoundationIdentity instance);
        partial void GetProperties_PreCondition(ITeamFoundationIdentity instance);
        partial void GetProperty_PostValidate(ITeamFoundationIdentity instance, String name);
        partial void GetProperty_PreCondition(ITeamFoundationIdentity instance, ref String name);
        static partial void InstanceFactory(ref TeamFoundationIdentityWrapper instance, [CallerMemberName] string callerName = "");

        partial void IsActive_SetCondition(ref ITeamFoundationIdentity instance, ref Boolean setValue);
        partial void IsContainer_SetCondition(ref ITeamFoundationIdentity instance, ref Boolean setValue);

        partial void MemberOf_SetCondition(ref ITeamFoundationIdentity instance, ref IIdentityDescriptor[] setValue);

        partial void Members_SetCondition(ref ITeamFoundationIdentity instance, ref IIdentityDescriptor[] setValue);
        static partial void RealInstanceFactory(ref TeamFoundationIdentity real, [CallerMemberName] string callerName = "");
        partial void RemoveProperty_PostValidate(ITeamFoundationIdentity instance, String name);
        partial void RemoveProperty_PreCondition(ITeamFoundationIdentity instance, ref String name);
        partial void SetAttribute_PostValidate(ITeamFoundationIdentity instance, String name, String value);
        partial void SetAttribute_PreCondition(ITeamFoundationIdentity instance, ref String name, ref String value);
        partial void SetProperty_PostValidate(ITeamFoundationIdentity instance, String name, Object value);
        partial void SetProperty_PreCondition(ITeamFoundationIdentity instance, ref String name, ref Object value);

        partial void TeamFoundationId_SetCondition(ref ITeamFoundationIdentity instance, ref Guid setValue);
        partial void TryGetProperty_PostValidate(ITeamFoundationIdentity instance, String name, Object value);
        partial void TryGetProperty_PreCondition(ITeamFoundationIdentity instance, ref String name, ref Object value);
        partial void UniqueName_SetCondition(ref ITeamFoundationIdentity instance, ref String setValue);

        partial void UniqueUserId_SetCondition(ref ITeamFoundationIdentity instance, ref Int32 setValue);
    }
}