using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Common
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class VariableSizeListImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Clear_UnitTest()
        {
            ExecuteMethod(
                () => { return (IVariableSizeList) GetInstance(); },
                instance => { Clear_PreCondition(ref instance); },
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
                    RemoveAt_PreCondition(ref instance, ref index);
                },
                instance => { instance.RemoveAt(index); },
                instance => { RemoveAt_PostValidate(instance, index); });
        }

        partial void Clear_PostValidate(IVariableSizeList instance);
        partial void Clear_PreCondition(ref IVariableSizeList instance);
        internal static IEnumerable<VariableSizeListImpl> GetIEnumerableInstance() { return new List<VariableSizeListImpl> {GetInstance()}; }

        internal static VariableSizeListImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new VariableSizeListImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref VariableSizeListImpl instance, [CallerMemberName] string callerName = "");
        partial void RemoveAt_PostValidate(IVariableSizeList instance, Int32 index);
        partial void RemoveAt_PreCondition(ref IVariableSizeList instance, ref Int32 index);
    }
}