using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConfusedFramework
{
    public class QuoteEntry
    {

        public static void GoTo()
        {
            /*TEST*/
            Driver.Instance.Navigate().GoToUrl("https://confusedlifetest2.directlife.co.uk");
            /*LIVE*/
            //driver.Navigate().GoToUrl("https://life.confused.com");
        }

        public static void PolicyTypeLevelTerm()
        {
            var level = Driver.Instance.FindElement(By.XPath("//LABEL[@for='PolicyType-1'][text()='Life insurance']/self::LABEL"));
            level.Click();
        }

        public static void PolicyTerm(string v)
        {
            var term = Driver.Instance.FindElement(By.Id("Term"));
            term.SendKeys(v);
        }

        public static void App1DOBDD(string v)
        {
            var dobdd = Driver.Instance.FindElement(By.Id("Applicant1_DOBDD"));
            var selectElement = new SelectElement(dobdd);
            selectElement.SelectByText(v);
        }

        public static void SmokingNever()
        {
            var smokingNever = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_SmokerStatus-1'][text()='Never smoked']"));
            smokingNever.Click();
        }

        public static void QuotePlusFamilyNo()
        {
            var qPlus3 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_13__AnswerValue_0'][text()='No']"));
            qPlus3.Click();
        }

        public static void QuotePlusActivitiesNo()
        {
            var qPlus8 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_18__AnswerValue_0'][text()='No']"));
            qPlus8.Click();
        }

        public static void QuotePlusAlcoholNo()
        {
            var qPlus13 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_23__AnswerValue_0'][text()='No']"));
            qPlus13.Click();
        }

        public static void ClickGetAQuoteButton()
        {
            var submitButton = Driver.Instance.FindElement(By.Id("btnSubmit"));
            submitButton.Click();
        }

        public static void QuotePlusExistingCoverNo()
        {
            var qPlus14 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_24__AnswerValue_0'][text()='No']"));
            qPlus14.Click();
        }

        public static void QuotePlusDrugsNo()
        {
            var qPlus12 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_22__AnswerValue_0'][text()='No']"));
            qPlus12.Click();
        }

        public static void QuotePlusDrivingNo()
        {
            var qPlus11 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_21__AnswerValue_0'][text()='No']"));
            qPlus11.Click();
        }

        public static void QuotePlusTravelNo()
        {
            var qPlus10 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_20__AnswerValue_0'][text()='No']"));
            qPlus10.Click();
        }

        public static void QuotePlusOccupationNo()
        {
            var qPlus9 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_19__AnswerValue_0'][text()='No']"));
            qPlus9.Click();
        }

        public static void QuotePlusHIVNo()
        {
            var qPlus7 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_17__AnswerValue_0'][text()='No']"));
            qPlus7.Click();
        }

        public static void QuotePlusMedicalAdviceNo()
        {
            var qPlus6 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_16__AnswerValue_0'][text()='No']"));
            qPlus6.Click();
        }

        public static void QuotePlusKidneyFailureNo()
        {
            var qPlus5 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_15__AnswerValue_0'][text()='No']"));
            qPlus5.Click();
        }

        public static void QuotePlusChestPainNo()
        {
            var qPlus4 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_14__AnswerValue_0'][text()='No']"));
            qPlus4.Click();
        }

        public static void QuotePlusMedicationNo()
        {
            var qPlus2 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_12__AnswerValue_0'][text()='No']"));
            qPlus2.Click();
        }

        public static void QuotePlusMedicalTreatmentNo()
        {
            var qPlus1 = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_QuestionSet_11__AnswerValue_0'][text()='No']"));
            qPlus1.Click();
        }

        public static void MedicalTreatment()
        {
            throw new NotImplementedException();
        }

        public static void ClickNextButton()
        {
            var nextButton = Driver.Instance.FindElement(By.Id("btnNext"));
            nextButton.Click();
        }

        public static void AlcoholUnits(string v)
        {
            var alcoholUnits = Driver.Instance.FindElement(By.Id("Applicant1_QuestionSet_10__AnswerValue"));
            alcoholUnits.SendKeys(v);
        }

        public static void App1WeightLbs(string v)
        {
            var weightLbs1 = Driver.Instance.FindElement(By.Id("Applicant1_WeightPounds"));
            weightLbs1.SendKeys(v);
        }

        public static void App1WeightStone(string v)
        {
            var weightStone1 = Driver.Instance.FindElement(By.Id("Applicant1_WeightStone"));
            weightStone1.SendKeys(v);
        }

        public static void App1HeightIns(string v)
        {
            var heightIns1 = Driver.Instance.FindElement(By.Id("Applicant1_HeightInches"));
            heightIns1.SendKeys(v);
        }

        public static void App1HeightFt(string v)
        {
            var heightFeet1 = Driver.Instance.FindElement(By.Id("Applicant1_HeightFeet"));
            heightFeet1.SendKeys(v);
        }

        public static void Telephone(string v)
        {
            var telephone = Driver.Instance.FindElement(By.Id("Applicant1_PhoneHome"));
            telephone.SendKeys(v);
        }

        public static void App1DOBMM(string v)
        {
            var dobmm = Driver.Instance.FindElement(By.Id("Applicant1_DOBMM"));
            var selectElement = new SelectElement(dobmm);
            selectElement.SelectByText(v);
        }


        public static void App1DOBYY(string v)
        {
            var dobyyyy = Driver.Instance.FindElement(By.Id("Applicant1_DOBYYYY"));
            var selectElement = new SelectElement(dobyyyy);
            selectElement.SelectByText(v);
        }

        public static void Postcode(string v)
        {
            var postcode = Driver.Instance.FindElement(By.Id("Applicant1_PostCode"));
            postcode.SendKeys(v);
        }

        public static void Email(string v)
        {
            var email = Driver.Instance.FindElement(By.Id("Applicant1_Email"));
            email.SendKeys(v);
        }

        public static void SumAssured(string v)
        {
            var sum = Driver.Instance.FindElement(By.Id("SumAssured"));
            sum.SendKeys(v);
        }

        public static void TitleMr()
        {
            var titleMr = Driver.Instance.FindElement(By.XPath("//LABEL[@for='Applicant1_AppTitle-1'][text()='Mr']"));
            titleMr.Click();
        }

        public static void App1FirstName(string v)
        {
            var firstName1 = Driver.Instance.FindElement(By.Id("Applicant1_Forename"));
            firstName1.SendKeys(v);
        }

        public static void App1Surname(string v)
        {
            var surname1 = Driver.Instance.FindElement(By.Id("Applicant1_Surname"));
            surname1.SendKeys(v);
        }



    }
}
