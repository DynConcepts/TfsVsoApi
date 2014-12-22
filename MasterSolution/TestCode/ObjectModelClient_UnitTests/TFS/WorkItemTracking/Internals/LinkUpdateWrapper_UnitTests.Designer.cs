using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class LinkUpdateWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Mask_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILinkUpdate) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Mask; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Submit_UnitTest()
        {
            XmlElement element = default(XmlElement);
            ExecuteMethod(
                () => { return (ILinkUpdate) GetInstance(); },
                instance =>
                {
                    element = default(XmlElement); //No Type
                    Submit_PreCondition(ref instance, ref element);
                },
                instance => { instance.Submit(element); },
                instance => { Submit_PostValidate(instance, element); });
        }

        internal static IEnumerable<LinkUpdateWrapper> GetIEnumerableInstance() { return new List<LinkUpdateWrapper> {GetInstance()}; }

        internal static LinkUpdateWrapper GetInstance()
        {
            LinkUpdate real = default(LinkUpdate);
            RealInstanceFactory(ref real);
            var instance = (LinkUpdateWrapper) LinkUpdateWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref LinkUpdateWrapper instance, [CallerMemberName] string callerName = "");
        partial void Mask_SetCondition(ref ILinkUpdate instance, ref ILinkProperties setValue);

        static partial void RealInstanceFactory(ref LinkUpdate real, [CallerMemberName] string callerName = "");
        partial void Submit_PostValidate(ILinkUpdate instance, XmlElement element);
        partial void Submit_PreCondition(ref ILinkUpdate instance, ref XmlElement element);
    }
}