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

            //BOOKMARK - get it so that user can pass string to PolicyTerm
            QuoteEntry.PolicyTerm();
        }
    }
}
