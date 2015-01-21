using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AttachmentWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AttachedTimeUtc_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAttachment) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AttachedTimeUtc; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AttachedTime_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAttachment) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AttachedTime; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Extension_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAttachment) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Extension; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FileGuid_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAttachment) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FileGuid; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AttachedTimeUtc_SetCondition(ref IAttachment instance, ref DateTime setValue);
        partial void AttachedTime_SetCondition(ref IAttachment instance, ref DateTime setValue);

        partial void Extension_SetCondition(ref IAttachment instance, ref String setValue);

        partial void FileGuid_SetCondition(ref IAttachment instance, ref String setValue);
        internal static IEnumerable<AttachmentWrapper> GetIEnumerableInstance() { return new List<AttachmentWrapper> {GetInstance()}; }

        internal static AttachmentWrapper GetInstance()
        {
            Attachment real = default(Attachment);
            RealInstanceFactory(ref real);
            var instance = (AttachmentWrapper) AttachmentWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref AttachmentWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref Attachment real, [CallerMemberName] string callerName = "");
    }
}