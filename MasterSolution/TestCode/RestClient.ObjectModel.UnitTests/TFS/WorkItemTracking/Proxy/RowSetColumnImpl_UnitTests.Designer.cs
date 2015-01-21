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
    public partial class RowSetColumnImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetSchema_UnitTest()
        {
            ExecuteMethod(
                () => { return (IRowSetColumn) GetInstance(); },
                instance => { GetSchema_PreCondition(instance); },
                instance => { instance.GetSchema(); },
                instance => { GetSchema_PostValidate(instance); });
        }

        internal static IEnumerable<RowSetColumnImpl> GetIEnumerableInstance() { return new List<RowSetColumnImpl> {GetInstance()}; }

        internal static RowSetColumnImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new RowSetColumnImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetSchema_PostValidate(IRowSetColumn instance);
        partial void GetSchema_PreCondition(IRowSetColumn instance);
        static partial void InstanceFactory(ref RowSetColumnImpl instance, [CallerMemberName] string callerName = "");
    }
}