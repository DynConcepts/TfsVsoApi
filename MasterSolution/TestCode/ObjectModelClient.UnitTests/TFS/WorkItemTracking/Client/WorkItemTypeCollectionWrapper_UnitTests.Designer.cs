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
    public partial class WorkItemTypeCollectionWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Import_UnitTest()
        {
            String definition = default(String);
            ExecuteMethod(
                () => { return (IWorkItemTypeCollection) GetInstance(); },
                instance =>
                {
                    definition = default(String); //No Constructor
                    Import_PreCondition(instance, ref definition);
                },
                instance => { instance.Import(definition); },
                instance => { Import_PostValidate(instance, definition); });
        }

        internal static IEnumerable<WorkItemTypeCollectionWrapper> GetIEnumerableInstance() { return new List<WorkItemTypeCollectionWrapper> {GetInstance()}; }

        internal static WorkItemTypeCollectionWrapper GetInstance()
        {
            WorkItemTypeCollection real = default(WorkItemTypeCollection);
            RealInstanceFactory(ref real);
            var instance = (WorkItemTypeCollectionWrapper) WorkItemTypeCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void Import_PostValidate(IWorkItemTypeCollection instance, String definition);
        partial void Import_PreCondition(IWorkItemTypeCollection instance, ref String definition);
        static partial void InstanceFactory(ref WorkItemTypeCollectionWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref WorkItemTypeCollection real, [CallerMemberName] string callerName = "");
    }
}