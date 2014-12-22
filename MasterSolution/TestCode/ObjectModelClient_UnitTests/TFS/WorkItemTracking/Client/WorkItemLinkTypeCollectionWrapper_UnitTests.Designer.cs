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
    public partial class WorkItemLinkTypeCollectionWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LinkTypeEnds_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkTypeCollection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LinkTypeEnds; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Validate_UnitTest()
        {
            String definitionXml = default(String);
            ExecuteMethod(
                () => { return (IWorkItemLinkTypeCollection) GetInstance(); },
                instance =>
                {
                    definitionXml = default(String); //No Constructor
                    Validate_PreCondition(ref instance, ref definitionXml);
                },
                instance => { instance.Validate(definitionXml); },
                instance => { Validate_PostValidate(instance, definitionXml); });
        }

        internal static IEnumerable<WorkItemLinkTypeCollectionWrapper> GetIEnumerableInstance() { return new List<WorkItemLinkTypeCollectionWrapper> {GetInstance()}; }

        internal static WorkItemLinkTypeCollectionWrapper GetInstance()
        {
            WorkItemLinkTypeCollection real = default(WorkItemLinkTypeCollection);
            RealInstanceFactory(ref real);
            var instance = (WorkItemLinkTypeCollectionWrapper) WorkItemLinkTypeCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkTypeCollectionWrapper instance, [CallerMemberName] string callerName = "");
        partial void LinkTypeEnds_SetCondition(ref IWorkItemLinkTypeCollection instance, ref IWorkItemLinkTypeEndCollection setValue);

        static partial void RealInstanceFactory(ref WorkItemLinkTypeCollection real, [CallerMemberName] string callerName = "");
        partial void Validate_PostValidate(IWorkItemLinkTypeCollection instance, String definitionXml);
        partial void Validate_PreCondition(ref IWorkItemLinkTypeCollection instance, ref String definitionXml);
    }
}