using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsMessageHeaderImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetReader_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsMessageHeader) GetInstance(); },
                instance => { GetReader_PreCondition(instance); },
                instance => { instance.GetReader(); },
                instance => { GetReader_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Namespace_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsMessageHeader) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Namespace; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Write_UnitTest()
        {
            XmlDictionaryWriter writer = default(XmlDictionaryWriter);
            ExecuteMethod(
                () => { return (ITfsMessageHeader) GetInstance(); },
                instance =>
                {
                    writer = default(XmlDictionaryWriter); //No Type
                    Write_PreCondition(instance, ref writer);
                },
                instance => { instance.Write(writer); },
                instance => { Write_PostValidate(instance, writer); });
        }

        internal static IEnumerable<TfsMessageHeaderImpl> GetIEnumerableInstance() { return new List<TfsMessageHeaderImpl> {GetInstance()}; }

        internal static TfsMessageHeaderImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TfsMessageHeaderImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetReader_PostValidate(ITfsMessageHeader instance);
        partial void GetReader_PreCondition(ITfsMessageHeader instance);
        static partial void InstanceFactory(ref TfsMessageHeaderImpl instance, [CallerMemberName] string callerName = "");

        partial void Namespace_SetCondition(ref ITfsMessageHeader instance, ref String setValue);
        partial void Write_PostValidate(ITfsMessageHeader instance, XmlDictionaryWriter writer);
        partial void Write_PreCondition(ITfsMessageHeader instance, ref XmlDictionaryWriter writer);
    }
}