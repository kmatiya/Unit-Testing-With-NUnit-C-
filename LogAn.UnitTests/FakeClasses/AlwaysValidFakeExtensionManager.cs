using Unit_Testing_With_NUnit.Interfaces;

namespace LogAn.UnitTests.FakeClasses
{
    public class AlwaysValidFakeExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}
