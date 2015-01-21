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
    public partial class LinkWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ArtifactLinkType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILink) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ArtifactLinkType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BaseType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILink) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.BaseType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void ArtifactLinkType_SetCondition(ref ILink instance, ref IRegisteredLinkType setValue);
        partial void BaseType_SetCondition(ref ILink instance, ref IBaseLinkType setValue);
        internal static IEnumerable<LinkWrapper> GetIEnumerableInstance() { return new List<LinkWrapper> {GetInstance()}; }

        internal static LinkWrapper GetInstance()
        {
            Link real = default(Link);
            RealInstanceFactory(ref real);
            var instance = (LinkWrapper) LinkWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref LinkWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref Link real, [CallerMemberName] string callerName = "");
    }
}