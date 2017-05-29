﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MapAppTest.Droid;
using MapAppTest;
using Xamarin.Forms.Maps;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMapPositionSetting()
        {
            double testLat = 0;
            double testLong = 0;
            double testRadius = 1;

            MappingEngine newEngine = new MappingEngine(null);

            newEngine.SetMapLocation(testLat, testLong, testRadius);

            Assert.AreEqual(newEngine.GetRadius(), testRadius);
            Assert.AreEqual(newEngine.GetLatitudeDegrees(), testLat);
            Assert.AreEqual(newEngine.GetLongitudeDegrees(), testLong);
            //Assert.IsTrue(false); // Test assert
        }
        [TestMethod]
        public void TestMapAddPin()
        {
            double testLat = 0;
            double testLong = 0;
            int testColor = 0x00FFFFFF;
            string testLabel = "testLabel";
            string testAddress = "123 Street";

            MappingEngine newEngine = new MappingEngine(null);
            bool result = newEngine.AddMarker(testLat, testLong, testColor, testLabel, testAddress);

            Assert.IsTrue(result);
        }
    }
}