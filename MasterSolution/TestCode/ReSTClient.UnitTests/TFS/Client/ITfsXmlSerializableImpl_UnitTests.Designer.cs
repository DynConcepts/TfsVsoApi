using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ITfsXmlSerializableImpl_UnitTests : DynTestClassBase
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
                    ReadXml_PreCondition(ref instance, ref reader, ref xmlElement);
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
                    WriteXml_PreCondition(ref instance, ref writer, ref xmlElement);
                },
                instance => { instance.WriteXml(writer, xmlElement); },
                instance => { WriteXml_PostValidate(instance, writer, xmlElement); });
        }

        internal static IEnumerable<ITfsXmlSerializableImpl> GetIEnumerableInstance() { return new List<ITfsXmlSerializableImpl> {GetInstance()}; }

        internal static ITfsXmlSerializableImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ITfsXmlSerializableImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ITfsXmlSerializableImpl instance, [CallerMemberName] string callerName = "");

        partial void ReadXml_PostValidate(IITfsXmlSerializable instance, XmlReader reader, String xmlElement);
        partial void ReadXml_PreCondition(ref IITfsXmlSerializable instance, ref XmlReader reader, ref String xmlElement);
        partial void WriteXml_PostValidate(IITfsXmlSerializable instance, XmlWriter writer, String xmlElement);
        partial void WriteXml_PreCondition(ref IITfsXmlSerializable instance, ref XmlWriter writer, ref String xmlElement);
    }
}