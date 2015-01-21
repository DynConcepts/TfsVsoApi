using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CatalogResourceTypeWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<CatalogResourceTypeWrapper> GetIEnumerableInstance() { return new List<CatalogResourceTypeWrapper> {GetInstance()}; }

        internal static CatalogResourceTypeWrapper GetInstance()
        {
            CatalogResourceType real = default(CatalogResourceType);
            RealInstanceFactory(ref real);
            var instance = (CatalogResourceTypeWrapper) CatalogResourceTypeWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref CatalogResourceTypeWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref CatalogResourceType real, [CallerMemberName] string callerName = "");
    }
}