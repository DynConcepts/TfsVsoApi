using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IdentityDescriptorWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Data_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentityDescriptor) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    object setValue = default(Object);
                    Data_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Data = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Data; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Identifier_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentityDescriptor) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Identifier; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IdentityType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentityDescriptor) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IdentityType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToXml_UnitTest()
        {
            XmlWriter writer = default(XmlWriter);
            String element = default(String);
            ExecuteMethod(
                () => { return (IIdentityDescriptor) GetInstance(); },
                instance =>
                {
                    writer = default(XmlWriter); //No Type
                    element = default(String); //No Constructor
                    ToXml_PreCondition(instance, ref writer, ref element);
                },
                instance => { instance.ToXml(writer, element); },
                instance => { ToXml_PostValidate(instance, writer, element); });
        }

        partial void Data_SetCondition(ref IIdentityDescriptor instance, ref Object setValue);
        internal static IEnumerable<IdentityDescriptorWrapper> GetIEnumerableInstance() { return new List<IdentityDescriptorWrapper> {GetInstance()}; }

        internal static IdentityDescriptorWrapper GetInstance()
        {
            IdentityDescriptor real = default(IdentityDescriptor);
            RealInstanceFactory(ref real);
            var instance = (IdentityDescriptorWrapper) IdentityDescriptorWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void Identifier_SetCondition(ref IIdentityDescriptor instance, ref String setValue);

        partial void IdentityType_SetCondition(ref IIdentityDescriptor instance, ref String setValue);
        static partial void InstanceFactory(ref IdentityDescriptorWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref IdentityDescriptor real, [CallerMemberName] string callerName = "");
        partial void ToXml_PostValidate(IIdentityDescriptor instance, XmlWriter writer, String element);
        partial void ToXml_PreCondition(IIdentityDescriptor instance, ref XmlWriter writer, ref String element);
    }
}