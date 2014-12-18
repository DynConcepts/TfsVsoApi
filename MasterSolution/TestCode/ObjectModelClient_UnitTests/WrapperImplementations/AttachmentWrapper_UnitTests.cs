using System;
using System.Linq;
using System.Reflection;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.WrapperImplementations
{
    /// <summary>
    /// Class Wrapper_UnitTestsBase.
    /// </summary>
    public class Wrapper_UnitTestsBase
    {
        /// <summary>
        /// Reads all properties.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="instance">The instance.</param>
        protected static void ReadAllProperties(Type type, object instance)
        {
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                if (property.CanRead && !property.CanWrite && property.GetIndexParameters().Length == 0)
                {
                    var getter = property.GetGetMethod();
                    var value = getter.Invoke(instance, new object[] {});
                    Console.WriteLine("Invoked {0}", property.Name);
                }
            }
        }

        /// <summary>
        ///     Finds the type of the work item.
        /// </summary>
        /// <param name="workItemTypeName">Name of the work item type.</param>
        /// <returns>WorkItemType.</returns>
        internal static WorkItemType FindWorkItemType(string workItemTypeName)
        {
            var uri = new Uri("*****");  // TODO Put in appropriate value, then refactor
            var tpc = new TfsTeamProjectCollection(uri);
            tpc.EnsureAuthenticated();
            var workItemStore = tpc.GetService<WorkItemStore>();
            const string projectName = "RestPlaypen";
            Project item = workItemStore.Projects[projectName];
            WorkItemTypeCollection workItemTypes = item.WorkItemTypes;
            WorkItemType workItemType = workItemTypes.Cast<WorkItemType>().First(entry => entry.Name == workItemTypeName);
            return workItemType;
        }

        /// <summary>
        ///     Gets the test instance.
        /// </summary>
        /// <returns>IWorkItem.</returns>
        internal static IWorkItem GetTestWorkItem()
        {
            WorkItemType workItemType = FindWorkItemType("Task");
            var realInstance = new WorkItem(workItemType);
            IWorkItem instance = WorkItemWrapper.GetWrapper(realInstance);
            instance.Title = "Dummy Work IItem Created by Unit Tests of WorkItemWrapper";
            return instance;
        }
        internal static IWorkItemCollection GetTestWorkItemCollection()
        {
            IWorkItemCollection instance = null;
             return instance;
        }
    }

    /// <summary>
    /// Class AttachmentWrapper_UnitTests.
    /// </summary>
    [TestClass]
    public class AttachmentWrapper_UnitTests : Wrapper_UnitTestsBase
    {
        /// <summary>
        /// Assembly_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [AssemblyInitialize]
        public static void Assembly_Initialize(TestContext context)
        {
            MappedObjectInitializer.ForceInitialize(typeof(AttachmentWrapper).Assembly);
        }

        /// <summary>
        /// Reads all properties_ unit test.
        /// </summary>
        [TestMethod]
        public void ReadAllProperties_UnitTest()
        {
            var path = Assembly.GetExecutingAssembly().Location;
            var real = new Attachment(path);
            var instance = AttachmentWrapper.GetWrapper(real);
            ReadAllProperties(typeof (IAttachment), instance);
        }
    }
}
