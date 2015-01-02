using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.DynTest_UnitTests
{

    public class ListHolder
    {
        private readonly List<ListItem> _Items = new List<ListItem>();
        public void Add(ListItem listItem) { _Items.Add(listItem); }
    }

    public class ListItem
    {
    }

    [TestClass]
    public class SampleCapture_UnitTests : DynTestClassBase
    {
        [TestMethod]
        public void SampleCapture_UnitTest()
        {
            ExecuteMethod(
                () => { return new ListHolder(); },
                instance =>
                {
                },
                instance =>
                {
                    instance.Add(new ListItem())
                        ;
                },
                instance => { });
        }

    }
}
