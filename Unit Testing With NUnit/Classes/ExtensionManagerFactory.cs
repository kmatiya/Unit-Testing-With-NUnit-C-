﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Testing_With_NUnit.Interfaces;

namespace Unit_Testing_With_NUnit.Classes
{
    public class ExtensionManagerFactory
    {
        private static IExtensionManager customManager = null;

        public static IExtensionManager Create()
        {
            if (customManager != null)
            {
                return customManager;
            }
            return new FileExtensionManager();
        }

        public static void SetManager(IExtensionManager mgr)
        {
            customManager = mgr;
        }
    }
}
