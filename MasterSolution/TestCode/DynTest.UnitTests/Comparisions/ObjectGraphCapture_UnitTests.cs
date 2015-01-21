using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.DynTest.ChangeTracking;
using DynCon.OSI.DynTest.Comparisions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DynCon.OSI.DynTest.Comparisions.UnitTests
{
    [TestClass()]
    public class ObjectGraphCapture_UnitTests
    {
      class Foo
        {
#pragma warning disable 169
#pragma warning disable 649
            public int a;
            public double b;
            public string c;
            public DateTime d;
            public Foo e;
#pragma warning restore 649
#pragma warning restore 169
        }

      [TestMethod()]
      public void CaptureGraph_UnitTest()
      {
          var source = new Foo();
          var result = ObjectGraphCapture.CaptureGraph(source);
      }

        [TestMethod()]
        public void CaptureGraph_Chain_UnitTest()
        {
            var source = new Foo {e = new Foo()};

            var result = ObjectGraphCapture.CaptureGraph(source);
        }

        [TestMethod()]
        public void CaptureGraph_Loop_UnitTest()
        {
            var source = new Foo();

            source.e = source;
            var result = ObjectGraphCapture.CaptureGraph(source);
        }
        [TestMethod()]
        public void CaptureGraph_Compare_UnitTest()
        {
            var source = new Foo();
            source.e = new Foo();
            var initialGraph = ObjectGraphCapture.CaptureGraph(source);
            source.a++;
            source.c = "Changed";
            source.e = new Foo();
            source.e.a++;
            var finalGraph = ObjectGraphCapture.CaptureGraph(source);
            var result = GraphCompare.ReportChanges(initialGraph, finalGraph);
        }
    }
}
