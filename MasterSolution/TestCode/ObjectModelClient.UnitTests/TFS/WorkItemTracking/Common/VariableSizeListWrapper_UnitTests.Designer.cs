using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Common
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class VariableSizeListWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Clear_UnitTest()
        {
            ExecuteMethod(
                () => { return (IVariableSizeList) GetInstance(); },
                instance => { Clear_PreCondition(instance); },
                instance => { instance.Clear(); },
                instance => { Clear_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveAt_UnitTest()
        {
            Int32 index = default(Int32);
            ExecuteMethod(
                () => { return (IVariableSizeList) GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    RemoveAt_PreCondition(instance, ref index);
                },
                instance => { instance.RemoveAt(index); },
                instance => { RemoveAt_PostValidate(instance, index); });
        }

        partial void Clear_PostValidate(IVariableSizeList instance);
        partial void Clear_PreCondition(IVariableSizeList instance);
        internal static IEnumerable<VariableSizeListWrapper> GetIEnumerableInstance() { return new List<VariableSizeListWrapper> {GetInstance()}; }

        internal static VariableSizeListWrapper GetInstance()
        {
            VariableSizeList real = default(VariableSizeList);
            RealInstanceFactory(ref real);
            var instance = (VariableSizeListWrapper) VariableSizeListWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref VariableSizeListWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref VariableSizeList real, [CallerMemberName] string callerName = "");
        partial void RemoveAt_PostValidate(IVariableSizeList instance, Int32 index);
        partial void RemoveAt_PreCondition(IVariableSizeList instance, ref Int32 index);
    }
}