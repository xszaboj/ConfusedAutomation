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
            //YOUR POLICY DETAILS
            QuoteEntry.PolicyTypeLevelTerm();
            QuoteEntry.PolicyTerm("28");
            QuoteEntry.SumAssured("180000");
            QuoteEntry.TitleMr();
            QuoteEntry.App1FirstName("James");
            QuoteEntry.App1Surname("Test");
            QuoteEntry.App1DOBDD("01");
            QuoteEntry.App1DOBMM("January");
            QuoteEntry.App1DOBYY("1985");
            QuoteEntry.Postcode("PO19 1JG");
            QuoteEntry.Email("james.aslett@directlife.co.uk");
            QuoteEntry.Telephone("07777777777");
            QuoteEntry.App1HeightFt("5");
            QuoteEntry.App1HeightIns("10");
            QuoteEntry.App1WeightStone("11");
            QuoteEntry.App1WeightLbs("0");
            //QUOTE+ SECTION 1
            QuoteEntry.SmokingNever();
            QuoteEntry.AlcoholUnits("0");
            QuoteEntry.ClickNextButton();
            //QUOTE+ SECTION 2
            QuoteEntry.QuotePlusMedicalTreatmentNo();
            QuoteEntry.QuotePlusMedicationNo();
            QuoteEntry.QuotePlusFamilyNo();
            QuoteEntry.ClickNextButton();
            //QUOTE+ SECTION 3
            QuoteEntry.QuotePlusChestPainNo();
            QuoteEntry.QuotePlusKidneyFailureNo();
            QuoteEntry.QuotePlusMedicalAdviceNo();
            QuoteEntry.QuotePlusHIVNo();
            QuoteEntry.ClickNextButton();
            //QUOTE+ SECTION 4
            QuoteEntry.QuotePlusActivitiesNo();
            QuoteEntry.QuotePlusOccupationNo();
            QuoteEntry.QuotePlusTravelNo();
            QuoteEntry.QuotePlusDrivingNo();
            QuoteEntry.QuotePlusDrugsNo();
            QuoteEntry.QuotePlusAlcoholNo();
            QuoteEntry.QuotePlusExistingCoverNo();
            QuoteEntry.ClickNextButton();
            QuoteEntry.ClickGetAQuoteButton();
            //RESULTS SCREEN
            Results.ApplyRoyalLondon();
            //UPSELL SCREEN
            Upsell.IndexationYes();
            Upsell.ClickContinueButton();
            //CHOSENQUOTE SCREEN
            ChosenQuote.ClickProceedButton();
        }
    }
}
