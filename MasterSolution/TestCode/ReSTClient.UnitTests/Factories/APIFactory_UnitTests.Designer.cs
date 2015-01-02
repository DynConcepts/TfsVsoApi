using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Factories;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Factories
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class APIFactory_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void JsonWorkItemAPI_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return APIFactory.JsonWorkItemAPI; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        partial void JsonWorkItemAPI_SetCondition(ref JsonWitAPI setValue);
    }
}