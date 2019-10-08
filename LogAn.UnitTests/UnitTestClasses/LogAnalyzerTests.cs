using System;
using NUnit.Framework;
using Unit_Testing_With_NUnit.Classes;

namespace LogAn.UnitTests.UnitTestClasses
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            Assert.False(result);
        }

        [TestCase("filewithgoodextension.SLF")]
        [TestCase("filewithgoodextension.slf")]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(file);

            Assert.True(result);
        }

//        [Test]
//        public void IsValidFileName_EmptyFileName_Throws()
//        {
//            LogAnalyzer la = MakeAnalyzer();
//            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
//            StringAssert.Contains("Filename has to be provided",ex.Message);
//        }

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid()
        {
            LogAnalyzer la = MakeAnalyzer();

            la.IsValidLogFileName("badname.foo");

            Assert.False(la.WasLastFileNameValid);
        }

        [TestCase("badfile.foo", false)]
        [TestCase("goodfile.slf", true)]
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected)
        {
            LogAnalyzer la = MakeAnalyzer();

            la.IsValidLogFileName(file);

            Assert.AreEqual(expected,la.WasLastFileNameValid);
        }
    }
}
