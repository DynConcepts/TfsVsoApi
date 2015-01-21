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


        class WithEvent
        {
            private int m_X;

            public int X
            {
                get { return m_X; }
                set
                {
                    m_X = value;
                    Fire_Changed();
                }
            }

            public event EventHandler Changed;

            private void Fire_Changed()
            {
                var shadow = Changed;
                if (shadow != null)
                    shadow(this, EventArgs.Empty);
            }
        }

        [TestMethod]
        public void EventTrap_UnitTest()
        {
            ExecuteMethod(
                () => new WithEvent(),
                instance =>
                {
                    ExpectEvent("Changed{DynCon.OSI.DynTest_UnitTests.SampleCapture_UnitTests+WithEvent}");
                },
                instance =>
                {
                    instance.X += 1;
                },
                instance => { });
        }

    }
}
