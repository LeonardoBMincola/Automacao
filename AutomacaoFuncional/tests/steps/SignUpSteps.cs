using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class SignUpSteps
    {
        private SignUpPageActions pageActions = new SignUpPageActions();

        [Given(@"Add email and click create account")]
        public void GivenAddEmailAndClickCreateAccount()
        {
            pageActions.AddEmailCreate();
        }

        [When(@"add the personal informations")]
        public void WhenAddThePersonalInformations()
        {
            pageActions.Add();
        }

        [When(@"Validate adress and proceed")]
        public void WhenValidateAdressAndProceed()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidateAdressAndProceed();
        }

        [Then(@"Create account successfully")]
        public void thenCreateAccountSuccessfully()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidateAccountCreate();
        }

        [When(@"Confirm payment and order")]
        public void WhenConfirmPaymentAndOrder()
        {
            pageActions.ConfirmPaymentOrder();
        }

        [Then(@"Finish")]
        public void thenFinish()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.Finish();
        }


    }
}
