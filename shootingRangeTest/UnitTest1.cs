using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Media;
using shootingRangeTest;
using System.Resources;

namespace shootingRangeTest
{
    [TestClass]
    public class UnitTest1
    {
        private object properties;
        [TestMethod]
        public void TestMethod1()
        {
            Form1 f = new Form1();
            System.Media.SoundPlayer _soundPlayer2 = new System.Media.SoundPlayer(Properties.Resources.load.wav);
            _soundPlayer2.Play();
            Assert.IsTrue(_soundPlayer2 != null);
        }





        private class Properties
        {
            public static object Resources { get; internal set; }
        }
    }

    public class Form1
    {
        public Form1()
        {

        }
    }
}
