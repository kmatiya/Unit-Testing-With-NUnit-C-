using System;
using Unit_Testing_With_NUnit.Interfaces;

namespace Unit_Testing_With_NUnit.Classes
{
    public class LogAnalyzer
    {

        private IExtensionManager manager;
        public LogAnalyzer()
        {
            manager = ExtensionManagerFactory.Create();
        }

        public bool WasLastFileNameValid { get; set; }
        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);
        }
    }
}
