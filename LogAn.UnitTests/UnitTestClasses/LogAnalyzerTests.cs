using System;
using LogAn.UnitTests.FakeClasses;
using LogAn.UnitTests.MockObjects;
using NUnit.Framework;
using Unit_Testing_With_NUnit.Classes;
using Unit_Testing_With_NUnit.Interfaces;

namespace LogAn.UnitTests.UnitTestClasses
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            StringAssert.Contains("Filename too short:abc.ext",mockService.LastError);
        }
    }
}
