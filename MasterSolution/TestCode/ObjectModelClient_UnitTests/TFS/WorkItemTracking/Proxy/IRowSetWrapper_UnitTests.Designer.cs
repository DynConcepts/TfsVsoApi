using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRowSet = Microsoft.TeamFoundation.WorkItemTracking.Proxy.IRowSet;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IRowSetWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ColumnCount_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIRowSet) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ColumnCount; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ContainsColumn_UnitTest()
        {
            String name = default(String);
            ExecuteMethod(
                () => { return (IIRowSet) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    ContainsColumn_PreCondition(ref instance, ref name);
                },
                instance => { instance.ContainsColumn(name); },
                instance => { ContainsColumn_PostValidate(instance, name); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RowCount_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIRowSet) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RowCount; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SwapRows_UnitTest()
        {
            Int32 row1 = default(Int32);
            Int32 row2 = default(Int32);
            ExecuteMethod(
                () => { return (IIRowSet) GetInstance(); },
                instance =>
                {
                    row1 = default(Int32); //No Constructor
                    row2 = default(Int32); //No Constructor
                    SwapRows_PreCondition(ref instance, ref row1, ref row2);
                },
                instance => { instance.SwapRows(row1, row2); },
                instance => { SwapRows_PostValidate(instance, row1, row2); });
        }

        partial void ColumnCount_SetCondition(ref IIRowSet instance, ref Int32 setValue);
        partial void ContainsColumn_PostValidate(IIRowSet instance, String name);
        partial void ContainsColumn_PreCondition(ref IIRowSet instance, ref String name);
        internal static IEnumerable<IRowSetWrapper> GetIEnumerableInstance() { return new List<IRowSetWrapper> {GetInstance()}; }

        internal static IRowSetWrapper GetInstance()
        {
            IRowSet real = default(IRowSet);
            RealInstanceFactory(ref real);
            var instance = (IRowSetWrapper) IRowSetWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IRowSetWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref IRowSet real, [CallerMemberName] string callerName = "");
        partial void RowCount_SetCondition(ref IIRowSet instance, ref Int32 setValue);
        partial void SwapRows_PostValidate(IIRowSet instance, Int32 row1, Int32 row2);
        partial void SwapRows_PreCondition(ref IIRowSet instance, ref Int32 row1, ref Int32 row2);
    }
}