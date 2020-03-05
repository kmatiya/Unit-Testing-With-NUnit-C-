using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Testing_With_NUnit.Interfaces;

namespace Unit_Testing_With_NUnit.Classes
{
    public class LogAnalyzer2
    {
        public LogAnalyzer2(IWebService service, IEmailService email)
        {
            Email = email;
            Service = service;
        }
        public IWebService Service { set; get; }
        public IEmailService Email { set; get; }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                try
                {
                    Service.LogError("Filename too short:"+fileName);
                }
                catch (Exception e)
                {
                    Email.SendEmail("someone@somewhere.com","can't log",e.Message);
                }
            }
        }
    }
}
