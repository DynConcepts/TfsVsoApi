using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RowSetCollectionImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TryGetRowSet_UnitTest()
        {
            String name = default(String);
            IRowSet rowset = default(IRowSet);
            ExecuteMethod(
                () => { return (IRowSetCollection) GetInstance(); },
                instance =>
                {
                    name = default(String); //No Constructor
                    rowset = RowSetImpl_UnitTests.GetInstance();
                    TryGetRowSet_PreCondition(instance, ref name, ref rowset);
                },
                instance => { instance.TryGetRowSet(name, out rowset); },
                instance => { TryGetRowSet_PostValidate(instance, name, rowset); });
        }

        internal static IEnumerable<RowSetCollectionImpl> GetIEnumerableInstance() { return new List<RowSetCollectionImpl> {GetInstance()}; }

        internal static RowSetCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new RowSetCollectionImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref RowSetCollectionImpl instance, [CallerMemberName] string callerName = "");

        partial void TryGetRowSet_PostValidate(IRowSetCollection instance, String name, IRowSet rowset);
        partial void TryGetRowSet_PreCondition(IRowSetCollection instance, ref String name, ref IRowSet rowset);
    }
}