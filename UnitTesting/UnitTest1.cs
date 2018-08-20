using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Media;
using WindowsFormsApp16.Properties;
using WindowsFormsApp16;
using System;


namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
     //   private readonly object Properties;

        [TestMethod]
        public void TestMethod1()
        {
           // Form1 f = new Form1();
            SoundPlayer _soundPlayer1 = new SoundPlayer();
           
            _soundPlayer1.Play();
            Assert.IsTrue(_soundPlayer1 != null);
        }
    }
}
