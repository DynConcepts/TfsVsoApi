using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.WrapperImplementations
{
    /// <summary>
    /// Class FieldCollectionWrapper_UnitTests.
    /// </summary>
    [TestClass]
    public class FieldCollectionWrapper_UnitTests : Wrapper_UnitTestsBase
    {
        /// <summary>
        /// Reads all properties_ unit test.
        /// </summary>
        [TestMethod]
        public void ReadAllProperties_UnitTest()
        {
            var workItem = GetTestWorkItem();
            var real = WorkItemWrapper.GetInstance(workItem).Fields;
             var instance = FieldCollectionWrapper.GetWrapper(real);
            ReadAllProperties(typeof(IFieldCollection), instance);
        }
    }
}
