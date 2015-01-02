using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CatalogResourceTypeImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<CatalogResourceTypeImpl> GetIEnumerableInstance() { return new List<CatalogResourceTypeImpl> {GetInstance()}; }

        internal static CatalogResourceTypeImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new CatalogResourceTypeImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref CatalogResourceTypeImpl instance, [CallerMemberName] string callerName = "");
    }
}