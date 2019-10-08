using System;

namespace Unit_Testing_With_NUnit.Classes
{
    public class LogAnalyzer
    {
        public bool WasLastFileNameValid { get; set; }
        public bool IsValidLogFileName(string fileName)
        {
            if (!fileName.EndsWith(".SLF",StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            WasLastFileNameValid = true;
            return true;
        }
    }
}
