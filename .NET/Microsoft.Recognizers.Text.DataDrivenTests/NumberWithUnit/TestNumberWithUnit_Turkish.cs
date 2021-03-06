﻿using Microsoft.Recognizers.Text.DataDrivenTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Recognizers.Text.NumberWithUnit.Tests
{
    [TestClass]
    public class TestNumberWithUnit_Turkish : TestBase
    {
        public static TestResources TestResources { get; protected set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            TestResources = new TestResources();
            TestResources.InitFromTestContext(context);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            TestSpecInitialize(TestResources);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "AgeModel-Turkish.csv", "AgeModel-Turkish#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void AgeModel()
        {
            TestNumberWithUnit();
        } 

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "DimensionModel-Turkish.csv", "DimensionModel-Turkish#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DimensionModel()
        {
            TestNumberWithUnit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TemperatureModel-Turkish.csv", "TemperatureModel-Turkish#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TemperatureModel()
        {
            TestNumberWithUnit();
        }
    }
}
