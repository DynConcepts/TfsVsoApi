using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RevisionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Attachments_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IRevision) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Attachments; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Fields_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IRevision) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Fields; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTagLine_UnitTest()
        {
            ExecuteMethod(
                () => { return (IRevision) GetInstance(); },
                instance => { GetTagLine_PreCondition(instance); },
                instance => { instance.GetTagLine(); },
                instance => { GetTagLine_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Index_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IRevision) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Index; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Links_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IRevision) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Links; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Attachments_SetCondition(ref IRevision instance, ref IAttachmentCollection setValue);
        partial void Fields_SetCondition(ref IRevision instance, ref IFieldCollection setValue);
        internal static IEnumerable<RevisionImpl> GetIEnumerableInstance() { return new List<RevisionImpl> {GetInstance()}; }

        internal static RevisionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            var instance = (RevisionImpl) RevisionImpl.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetTagLine_PostValidate(IRevision instance);
        partial void GetTagLine_PreCondition(IRevision instance);
        partial void Index_SetCondition(ref IRevision instance, ref Int32 setValue);
        static partial void InstanceFactory(ref RevisionImpl instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);

        partial void Links_SetCondition(ref IRevision instance, ref ILinkCollection setValue);
    }
}