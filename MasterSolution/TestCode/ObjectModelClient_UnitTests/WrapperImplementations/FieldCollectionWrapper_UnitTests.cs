using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.WrapperImplementations
{
    /// <summary>
    ///     Class FieldCollectionWrapper_UnitTests.
    /// </summary>
    [TestClass]
    public class FieldCollectionWrapper_UnitTests : Wrapper_UnitTestsBase
    {
        /// <summary>
        ///     Reads all properties_ unit test.
        /// </summary>
        [TestMethod]
        public void ReadAllProperties_UnitTest()
        {
            IWorkItem workItem = GetTestWorkItem();
            FieldCollection real = WorkItemWrapper.GetInstance(workItem).Fields;
            IFieldCollection instance = FieldCollectionWrapper.GetWrapper(real);
            ReadAllProperties(typeof (IFieldCollection), instance);
        }
    }
}