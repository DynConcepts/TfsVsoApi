using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsMessageHeaderWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetReader_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsMessageHeader) GetInstance(); },
                instance => { GetReader_PreCondition(ref instance); },
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
                    Write_PreCondition(ref instance, ref writer);
                },
                instance => { instance.Write(writer); },
                instance => { Write_PostValidate(instance, writer); });
        }

        internal static IEnumerable<TfsMessageHeaderWrapper> GetIEnumerableInstance() { return new List<TfsMessageHeaderWrapper> {GetInstance()}; }

        internal static TfsMessageHeaderWrapper GetInstance()
        {
            TfsMessageHeader real = default(TfsMessageHeader);
            RealInstanceFactory(ref real);
            var instance = (TfsMessageHeaderWrapper) TfsMessageHeaderWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetReader_PostValidate(ITfsMessageHeader instance);
        partial void GetReader_PreCondition(ref ITfsMessageHeader instance);
        static partial void InstanceFactory(ref TfsMessageHeaderWrapper instance, [CallerMemberName] string callerName = "");

        partial void Namespace_SetCondition(ref ITfsMessageHeader instance, ref String setValue);
        static partial void RealInstanceFactory(ref TfsMessageHeader real, [CallerMemberName] string callerName = "");
        partial void Write_PostValidate(ITfsMessageHeader instance, XmlDictionaryWriter writer);
        partial void Write_PreCondition(ref ITfsMessageHeader instance, ref XmlDictionaryWriter writer);
    }
}