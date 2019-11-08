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
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;
            LogAnalyzer log = new LogAnalyzer(myFakeManager);
            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
        }

        [Test]
        public void IsValidFileName_ExtManagerThrowsException_ReturnsFalse()
        {
            FakeExtensionManager myFakeExtensionManager = new FakeExtensionManager();
            myFakeExtensionManager.WillThrow = new Exception("this is fake");
            LogAnalyzer log = new LogAnalyzer(myFakeExtensionManager);
            bool result = log.IsValidLogFileName("anything.anyextension");
            Assert.False(result);
        }
//        [Test]
//        public void IsValidFileName_BadExtension_ReturnsFalse()
//        {
//            LogAnalyzer analyzer = new LogAnalyzer(new FakeExtensionManager());
//            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
//            Assert.False(result);
//        }

//        [TestCase("filewithgoodextension.SLF")]
//        [TestCase("filewithgoodextension.slf")]
//        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
//        {
//            FakeExtensionManager myFakeExtensionManager = new FakeExtensionManager();
//            LogAnalyzer analyzer = new LogAnalyzer(myFakeExtensionManager);
//            bool result = analyzer.IsValidLogFileName(file);
//
//            Assert.True(result);
//        }
            
        
//        [Test]
//        public void IsValidFileName_EmptyFileName_Throws()
//        {
//            LogAnalyzer la = MakeAnalyzer();
//            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
//            StringAssert.Contains("Filename has to be provided",ex.Message);
//        }

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer(new FakeExtensionManager());
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

        [Test]
        //the unit of work under test:
        public bool IsValidLogFileName(string fileName)
        {
            IExtensionManager mgr = new FileExtensionManager();
            return mgr.IsValid(fileName);
        }
    }
}
