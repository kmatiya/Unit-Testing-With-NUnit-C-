﻿using System;
using Unit_Testing_With_NUnit.Interfaces;

namespace Unit_Testing_With_NUnit.Classes
{
    public class LogAnalyzer
    {
        private IWebService service;

        public LogAnalyzer(IWebService service)
        {
            this.service = service;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                service.LogError("Filename too short:"+ fileName);
            }
        }
    }
}
