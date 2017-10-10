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
            QuoteEntry.PolicyTypeLevelTerm();
            QuoteEntry.PolicyTerm("28");
            QuoteEntry.SumAssured("180000");
            QuoteEntry.TitleMr();
            QuoteEntry.App1FirstName("James");
            QuoteEntry.App1Surname("Test");
        }
    }
}
