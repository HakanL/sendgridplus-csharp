﻿using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SendGrid;

namespace SendGrid.Tests
{
    [TestClass]
    public class TestJsonUtils
    {
        [TestMethod]
        public void TestSerialize()
        {
            Assert.AreEqual("1", Utils.Serialize(1));
            Assert.AreEqual("\"\\\"foo\\\"\"", Utils.Serialize("\"foo\""));
        }
    }
}
