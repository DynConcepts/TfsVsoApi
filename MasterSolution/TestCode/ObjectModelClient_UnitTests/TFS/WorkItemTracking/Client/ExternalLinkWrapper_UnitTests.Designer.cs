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
    public partial class ExternalLinkWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LinkedArtifactUri_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IExternalLink) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LinkedArtifactUri; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<ExternalLinkWrapper> GetIEnumerableInstance() { return new List<ExternalLinkWrapper> {GetInstance()}; }

        internal static ExternalLinkWrapper GetInstance()
        {
            ExternalLink real = default(ExternalLink);
            RealInstanceFactory(ref real);
            var instance = (ExternalLinkWrapper) ExternalLinkWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ExternalLinkWrapper instance, [CallerMemberName] string callerName = "");

        partial void LinkedArtifactUri_SetCondition(ref IExternalLink instance, ref String setValue);
        static partial void RealInstanceFactory(ref ExternalLink real, [CallerMemberName] string callerName = "");
    }
}