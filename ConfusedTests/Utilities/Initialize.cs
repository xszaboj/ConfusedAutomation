using ConfusedFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfusedTests
{
    public class Initialize
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
    }
}
