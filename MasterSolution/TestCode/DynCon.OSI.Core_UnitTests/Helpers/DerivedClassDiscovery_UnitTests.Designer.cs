using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.Core_UnitTests.Helpers
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class DerivedClassDiscovery_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FindDerived_UnitTest()
        {
            Type baseType = default(Type);
            IEnumerable<Type> _retVal = default(IEnumerable<Type>);
            ExecuteMethod(
                () =>
                {
                    baseType = default(Type); //No Constructor
                    FindDerived_PreCondition(ref baseType);
                },
                () => { _retVal = DerivedClassDiscovery.FindDerived(baseType); },
                () => { FindDerived_PostValidate(baseType, _retVal); });
        }

        partial void FindDerived_PostValidate(Type baseType, IEnumerable<Type> _retVal);
        partial void FindDerived_PreCondition(ref Type baseType);
    }
}