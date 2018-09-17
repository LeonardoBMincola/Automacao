using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AutomacaoFuncional.tests.pages
{
    class ProductPageActions : ProductElementsMap
    {

        private ClassUtilities util = new ClassUtilities();


        public ProductPageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void SelectProduct()
        {
            try
            {
                util.WaitForElementVisible(productItem, 5);
                ((IJavaScriptExecutor)ClassDriver.GetInstance().Driver).ExecuteScript("arguments[0].click();", ClassDriver.GetInstance().Driver.FindElement(By.XPath("//a[@class='button lnk_view btn btn-default'][1]")));
            }
            catch (Exception)
            {

            }
        }

        public void AddCart()
        {
            try
            {
                util.WaitForElementVisible(nameProduct, 5);

                if (btnAddCart.Displayed && btnAddCart.Enabled)
                {
                    btnAddCart.Click();
                    Thread.Sleep(2000);
                }
            }
            catch
            {

            }
        }

        //public bool ValidateCheckoutPage()
        //{

        //    bool _result = false;
        //    try
        //    {
        //        Thread.Sleep(3000);
        //        util.WaitForElementVisible(btnProceed, 5);
        //        if (btnProceed.Displayed)
        //        {
        //            btnProceed.Click();
        //            _result = true;
        //        }
        //        else
        //        {
        //            ClassInfo.GetInstance().LogMessage = "Icon not visible";
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        ClassInfo.GetInstance().LogMessage = "Error on validate";
        //    }
        //    return _result;
        //}

 
        public void ProceedToCheckout()
        {
            try
            {
                Thread.Sleep(3000);
                util.WaitForElementVisible(btnProceed, 5);
                if (btnProceed.Displayed)
                {
                    btnProceed.Click();
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Btn not visible";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }

        }

        public bool ValidateCart(String arg)
        {
            bool _result = false;
            try
            {
                Thread.Sleep(3000);
                util.WaitForElementVisible(cartTitle, 5);
                IWebElement product = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//a[text()='"+arg+"']"));
                
                if (cartTitle.Displayed && product.Displayed)
                {
                    ClassDriver.GetInstance().Driver.FindElement(By.XPath("//p[@class='cart_navigation clearfix']//a")).Click();
                     _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Error";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate cart";
            }
            return _result;
        }
    }


    
}
