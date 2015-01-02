using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfsMessageImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Action_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsMessage) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Action; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreateException_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsMessage) GetInstance(); },
                instance => { CreateException_PreCondition(ref instance); },
                instance => { instance.CreateException(); },
                instance => { CreateException_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetBodyReader_UnitTest()
        {
            ExecuteMethod(
                () => { return (ITfsMessage) GetInstance(); },
                instance => { GetBodyReader_PreCondition(ref instance); },
                instance => { instance.GetBodyReader(); },
                instance => { GetBodyReader_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Headers_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsMessage) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Headers; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsEmpty_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsMessage) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsEmpty; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsFault_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsMessage) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsFault; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void To_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ITfsMessage) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.To; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Action_SetCondition(ref ITfsMessage instance, ref String setValue);
        partial void CreateException_PostValidate(ITfsMessage instance);
        partial void CreateException_PreCondition(ref ITfsMessage instance);
        partial void GetBodyReader_PostValidate(ITfsMessage instance);
        partial void GetBodyReader_PreCondition(ref ITfsMessage instance);
        internal static IEnumerable<TfsMessageImpl> GetIEnumerableInstance() { return new List<TfsMessageImpl> {GetInstance()}; }

        internal static TfsMessageImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TfsMessageImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void Headers_SetCondition(ref ITfsMessage instance, ref Collection<ITfsMessageHeader> setValue);
        static partial void InstanceFactory(ref TfsMessageImpl instance, [CallerMemberName] string callerName = "");

        partial void IsEmpty_SetCondition(ref ITfsMessage instance, ref Boolean setValue);

        partial void IsFault_SetCondition(ref ITfsMessage instance, ref Boolean setValue);

        partial void To_SetCondition(ref ITfsMessage instance, ref Uri setValue);
    }
}