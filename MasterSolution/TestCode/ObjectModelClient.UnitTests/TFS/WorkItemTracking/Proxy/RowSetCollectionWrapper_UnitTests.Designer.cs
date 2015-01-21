using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRowSet = DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RowSetCollectionWrapper_UnitTests : DynTestClassBase
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
                    rowset = RowSetWrapper_UnitTests.GetInstance();
                    TryGetRowSet_PreCondition(instance, ref name, ref rowset);
                },
                instance => { instance.TryGetRowSet(name, out rowset); },
                instance => { TryGetRowSet_PostValidate(instance, name, rowset); });
        }

        internal static IEnumerable<RowSetCollectionWrapper> GetIEnumerableInstance() { return new List<RowSetCollectionWrapper> {GetInstance()}; }

        internal static RowSetCollectionWrapper GetInstance()
        {
            RowSetCollection real = default(RowSetCollection);
            RealInstanceFactory(ref real);
            var instance = (RowSetCollectionWrapper) RowSetCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref RowSetCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref RowSetCollection real, [CallerMemberName] string callerName = "");
        partial void TryGetRowSet_PostValidate(IRowSetCollection instance, String name, IRowSet rowset);
        partial void TryGetRowSet_PreCondition(IRowSetCollection instance, ref String name, ref IRowSet rowset);
    }
}