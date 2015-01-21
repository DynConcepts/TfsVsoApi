using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.DynTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.Core_UnitTests.ObjectMapping
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class MappedObjectInitializer_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ForceInitialize_UnitTest()
        {
            ExecuteMethod(
                () => { ForceInitialize_PreCondition(); },
                () => { MappedObjectInitializer.ForceInitialize(); },
                () => { ForceInitialize_PostValidate(); });
        }

        partial void ForceInitialize_PostValidate();
        partial void ForceInitialize_PreCondition();
    }
}