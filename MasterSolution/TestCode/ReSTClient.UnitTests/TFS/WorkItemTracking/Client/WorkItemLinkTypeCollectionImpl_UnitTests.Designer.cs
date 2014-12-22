using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemLinkTypeCollectionImpl_UnitTests : DynTestClassBase
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

        internal static IEnumerable<WorkItemLinkTypeCollectionImpl> GetIEnumerableInstance() { return new List<WorkItemLinkTypeCollectionImpl> {GetInstance()}; }

        internal static WorkItemLinkTypeCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemLinkTypeCollectionImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkTypeCollectionImpl instance, [CallerMemberName] string callerName = "");

        partial void LinkTypeEnds_SetCondition(ref IWorkItemLinkTypeCollection instance, ref IWorkItemLinkTypeEndCollection setValue);
        partial void Validate_PostValidate(IWorkItemLinkTypeCollection instance, String definitionXml);
        partial void Validate_PreCondition(ref IWorkItemLinkTypeCollection instance, ref String definitionXml);
    }
}