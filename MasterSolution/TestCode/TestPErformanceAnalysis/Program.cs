using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client;

namespace TestPErformanceAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeWrapper_UnitTests testClass = new NodeWrapper_UnitTests();
            testClass.ChildNodes_UnitTest();
        }
    }
}
