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
    public partial class RevisionWrapper_UnitTests : DynTestClassBase
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
                instance => { GetTagLine_PreCondition(ref instance); },
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
        internal static IEnumerable<RevisionWrapper> GetIEnumerableInstance() { return new List<RevisionWrapper> {GetInstance()}; }

        internal static RevisionWrapper GetInstance()
        {
            Revision real = default(Revision);
            RealInstanceFactory(ref real);
            var instance = (RevisionWrapper) RevisionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetTagLine_PostValidate(IRevision instance);
        partial void GetTagLine_PreCondition(ref IRevision instance);
        partial void Index_SetCondition(ref IRevision instance, ref Int32 setValue);
        static partial void InstanceFactory(ref RevisionWrapper instance, [CallerMemberName] string callerName = "");

        partial void Links_SetCondition(ref IRevision instance, ref ILinkCollection setValue);
        static partial void RealInstanceFactory(ref Revision real, [CallerMemberName] string callerName = "");
    }
}