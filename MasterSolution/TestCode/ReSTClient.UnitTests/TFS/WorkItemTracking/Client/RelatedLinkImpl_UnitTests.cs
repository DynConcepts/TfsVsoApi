using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.APIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class RelatedLinkImpl_UnitTests
    {
        /// <summary>
        /// Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context) { var api = new JsonWorkItemAPI(); }

        private static readonly List<String> sr_DisabledTests = new List<string>()
        {
            "LinkTypeEnd_UnitTest",
            "RelatedWorkItemId_UnitTest"
        };

        /// <summary>
        /// Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

    }
}
