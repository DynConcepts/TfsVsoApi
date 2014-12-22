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
    public partial class WorkItemTypeCollectionImpl_UnitTests : DynTestClassBase
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
                    Import_PreCondition(ref instance, ref definition);
                },
                instance => { instance.Import(definition); },
                instance => { Import_PostValidate(instance, definition); });
        }

        internal static IEnumerable<WorkItemTypeCollectionImpl> GetIEnumerableInstance() { return new List<WorkItemTypeCollectionImpl> {GetInstance()}; }

        internal static WorkItemTypeCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            WorkItemTypeCollectionImpl instance = default(WorkItemTypeCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void Import_PostValidate(IWorkItemTypeCollection instance, String definition);
        partial void Import_PreCondition(ref IWorkItemTypeCollection instance, ref String definition);
        static partial void InstanceFactory(ref WorkItemTypeCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}