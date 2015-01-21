using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ITfsXmlSerializableWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ReadXml_UnitTest()
        {
            XmlReader reader = default(XmlReader);
            String xmlElement = default(String);
            ExecuteMethod(
                () => { return (IITfsXmlSerializable) GetInstance(); },
                instance =>
                {
                    reader = default(XmlReader); //No Type
                    xmlElement = default(String); //No Constructor
                    ReadXml_PreCondition(instance, ref reader, ref xmlElement);
                },
                instance => { instance.ReadXml(reader, xmlElement); },
                instance => { ReadXml_PostValidate(instance, reader, xmlElement); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WriteXml_UnitTest()
        {
            XmlWriter writer = default(XmlWriter);
            String xmlElement = default(String);
            ExecuteMethod(
                () => { return (IITfsXmlSerializable) GetInstance(); },
                instance =>
                {
                    writer = default(XmlWriter); //No Type
                    xmlElement = default(String); //No Constructor
                    WriteXml_PreCondition(instance, ref writer, ref xmlElement);
                },
                instance => { instance.WriteXml(writer, xmlElement); },
                instance => { WriteXml_PostValidate(instance, writer, xmlElement); });
        }

        internal static IEnumerable<ITfsXmlSerializableWrapper> GetIEnumerableInstance() { return new List<ITfsXmlSerializableWrapper> {GetInstance()}; }

        internal static ITfsXmlSerializableWrapper GetInstance()
        {
            ITfsXmlSerializable real = default(ITfsXmlSerializable);
            RealInstanceFactory(ref real);
            var instance = (ITfsXmlSerializableWrapper) ITfsXmlSerializableWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ITfsXmlSerializableWrapper instance, [CallerMemberName] string callerName = "");
        partial void ReadXml_PostValidate(IITfsXmlSerializable instance, XmlReader reader, String xmlElement);
        partial void ReadXml_PreCondition(IITfsXmlSerializable instance, ref XmlReader reader, ref String xmlElement);

        static partial void RealInstanceFactory(ref ITfsXmlSerializable real, [CallerMemberName] string callerName = "");
        partial void WriteXml_PostValidate(IITfsXmlSerializable instance, XmlWriter writer, String xmlElement);
        partial void WriteXml_PreCondition(IITfsXmlSerializable instance, ref XmlWriter writer, ref String xmlElement);
    }
}