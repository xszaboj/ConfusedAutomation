using ConfusedFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfusedTests
{
    [TestClass]
    public class EndToEndTests : Initialize
    {
        [TestMethod]
        public void SingleEndToEnd()
        {
            QuoteEntry.GoTo();
            QuoteEntry.LevelTerm();
        }
    }
}
