using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class ProductSteps
    {
        private ProductPageActions pageActions = new ProductPageActions();

        [Given(@"Click on product")]
        public void GivenClickOnProduct()
        {
            pageActions.SelectProduct();
        }

        [When(@"Click add cart")]
        public void WhenClickAddCart()
        {
          pageActions.AddCart();
        }

        //[Then(@"Checkout")]
        //public void ThenCheckout()
        //{
        //   ClassInfo.GetInstance().ResultScenario =  pageActions.ValidateCheckoutPage();        
        //}

        [When(@"Click on proceed to checkout")]
        public void WhenClickOnProceedToCheckout()
        {
            pageActions.ProceedToCheckout();
        }

        [Then(@"Verify product ""(.*)""")]
        public void ThenVerifyProduct(String arg)
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidateCart(arg);
        }

    }
}
