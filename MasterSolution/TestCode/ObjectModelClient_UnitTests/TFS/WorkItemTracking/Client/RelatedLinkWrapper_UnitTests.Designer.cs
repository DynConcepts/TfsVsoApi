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
    public partial class RelatedLinkWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LinkTypeEnd_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IRelatedLink) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LinkTypeEnd; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RelatedWorkItemId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IRelatedLink) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RelatedWorkItemId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<RelatedLinkWrapper> GetIEnumerableInstance() { return new List<RelatedLinkWrapper> {GetInstance()}; }

        internal static RelatedLinkWrapper GetInstance()
        {
            RelatedLink real = default(RelatedLink);
            RealInstanceFactory(ref real);
            var instance = (RelatedLinkWrapper) RelatedLinkWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref RelatedLinkWrapper instance, [CallerMemberName] string callerName = "");
        partial void LinkTypeEnd_SetCondition(ref IRelatedLink instance, ref IWorkItemLinkTypeEnd setValue);

        static partial void RealInstanceFactory(ref RelatedLink real, [CallerMemberName] string callerName = "");

        partial void RelatedWorkItemId_SetCondition(ref IRelatedLink instance, ref Int32 setValue);
    }
}