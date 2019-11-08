using System;
using LogAn.UnitTests.FakeClasses;
using NUnit.Framework;
using Unit_Testing_With_NUnit.Classes;
using Unit_Testing_With_NUnit.Interfaces;

namespace LogAn.UnitTests.UnitTestClasses
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_SupportedExtension_ReturnsTrue()
        {
            IExtensionManager myFakExtensionManager = new FakeExtensionManager();
            // Create analyser and inject stub
            LogAnalyzer log = new LogAnalyzer();
            log.ExtensionManager = myFakExtensionManager;
            bool result = log.IsValidLogFileName("text.txt");
            Assert.True(result);
        }
    }
}
