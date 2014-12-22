using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    public partial class IterationImpl_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "Children_UnitTest",
            "Parent_UnitTest",
            "Links_UnitTest"
        };
    }
}