using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RowSetColumnWrapper_UnitTests : DynTestClassBase
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

        internal static IEnumerable<RowSetColumnWrapper> GetIEnumerableInstance() { return new List<RowSetColumnWrapper> {GetInstance()}; }

        internal static RowSetColumnWrapper GetInstance()
        {
            RowSetColumn real = default(RowSetColumn);
            RealInstanceFactory(ref real);
            var instance = (RowSetColumnWrapper) RowSetColumnWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetSchema_PostValidate(IRowSetColumn instance);
        partial void GetSchema_PreCondition(IRowSetColumn instance);
        static partial void InstanceFactory(ref RowSetColumnWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref RowSetColumn real, [CallerMemberName] string callerName = "");
    }
}