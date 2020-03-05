using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Testing_With_NUnit.Interfaces;

namespace LogAn.UnitTests.MockObjects
{
    class FakeWebService : IWebService
    {
        public Exception ToThrow;
        public void LogError(string message)
        {
            if(ToThrow!=null)
            {
                throw ToThrow;
            }
        }
    }
}
