using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CategoryCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<CategoryCollectionImpl> GetIEnumerableInstance() { return new List<CategoryCollectionImpl> {GetInstance()}; }

        internal static CategoryCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new CategoryCollectionImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref CategoryCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}