using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class LinkUpdateImpl_UnitTests : DynTestClassBase
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

        internal static IEnumerable<LinkUpdateImpl> GetIEnumerableInstance() { return new List<LinkUpdateImpl> {GetInstance()}; }

        internal static LinkUpdateImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new LinkUpdateImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref LinkUpdateImpl instance, [CallerMemberName] string callerName = "");

        partial void Mask_SetCondition(ref ILinkUpdate instance, ref ILinkProperties setValue);
        partial void Submit_PostValidate(ILinkUpdate instance, XmlElement element);
        partial void Submit_PreCondition(ref ILinkUpdate instance, ref XmlElement element);
    }
}