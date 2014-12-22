using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client;

namespace TestPErformanceAnalysis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testClass = new NodeWrapper_UnitTests();
            testClass.ChildNodes_UnitTest();
        }
    }
}