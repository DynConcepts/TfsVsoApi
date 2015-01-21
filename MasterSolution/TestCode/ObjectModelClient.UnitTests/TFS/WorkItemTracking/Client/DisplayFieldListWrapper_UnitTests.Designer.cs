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
    public partial class DisplayFieldListWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Insert_UnitTest()
        {
            Int32 index = default(Int32);
            IFieldDefinition value = default(IFieldDefinition);
            ExecuteMethod(
                () => { return (IDisplayFieldList) GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    value = FieldDefinitionWrapper_UnitTests.GetInstance();
                    Insert_PreCondition(instance, ref index, ref value);
                },
                instance => { instance.Insert(index, value); },
                instance => { Insert_PostValidate(instance, index, value); });
        }

        internal static IEnumerable<DisplayFieldListWrapper> GetIEnumerableInstance() { return new List<DisplayFieldListWrapper> {GetInstance()}; }

        internal static DisplayFieldListWrapper GetInstance()
        {
            DisplayFieldList real = default(DisplayFieldList);
            RealInstanceFactory(ref real);
            var instance = (DisplayFieldListWrapper) DisplayFieldListWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void Insert_PostValidate(IDisplayFieldList instance, Int32 index, IFieldDefinition value);
        partial void Insert_PreCondition(IDisplayFieldList instance, ref Int32 index, ref IFieldDefinition value);
        static partial void InstanceFactory(ref DisplayFieldListWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref DisplayFieldList real, [CallerMemberName] string callerName = "");
    }
}