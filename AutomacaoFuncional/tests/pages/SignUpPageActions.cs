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
    class SignUpPageActions : SignUpElementsMap
    {

        private ClassUtilities util = new ClassUtilities();
        private MassaDeDados massa = new MassaDeDados();


        public SignUpPageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

      
        public void AddEmailCreate()
        {

            Random random = new Random();
            int valorInteiro = random.Next(1, 100000);
            var mail = valorInteiro + massa.email;

            try
            {
                Thread.Sleep(1000);
                util.WaitForElementVisible(inputEmail, 5);
                if (btnCreate.Displayed)
                {
                    inputEmail.Click();
                    inputEmail.SendKeys(mail);
                    Thread.Sleep(2000);
                    btnCreate.Click();
                }
            }
            catch
            {

            }
        }

        public bool Add()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(3000);
                IWebElement create = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='account_creation']/h3[text()='Your personal information']"));
                if (create.Displayed )
                {
                    gender.Click();
                    Thread.Sleep(600);
                    inputName.Click();
                    inputName.SendKeys(massa.name);
                    Thread.Sleep(600);
                    inputLastname.Click();
                    inputLastname.SendKeys(massa.lastname);
                    Thread.Sleep(600);
                    inputPasswrd.Click();
                    inputPasswrd.SendKeys(massa.passwrd);
                    Thread.Sleep(600);
                    inputAdress.Click();
                    inputAdress.SendKeys(massa.adress);
                    Thread.Sleep(600);
                    inputCity.Click();
                    inputCity.SendKeys(massa.city);
                    Thread.Sleep(600);
                    selectState.Click();
                    Thread.Sleep(600);
                    inputZip.Click();
                    inputZip.SendKeys(massa.zip);
                    Thread.Sleep(600);
                    inputPhone.Click();
                    inputPhone.SendKeys(massa.phone);
                    Thread.Sleep(600);
                    inputAlias.Click();
                    inputAlias.SendKeys(massa.alias);
                    Thread.Sleep(1000);
                    submitAccount.Click();
                    Thread.Sleep(2000);
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

        public bool ValidateAdressAndProceed()
        {
           bool _result = false;
            
            try
            {
                Thread.Sleep(2000);
                util.WaitForElementVisible(stepTitle, 10);
              IWebElement adress = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//li[1 and text()='"+massa.adress+" "+"']"));
             
                if (stepTitle.Displayed && adress.Displayed)
                {
                    btnProceed.Click();
                    Thread.Sleep(2000);
                    btnConfirm.Click();
                    Thread.Sleep(3000);
                    btnProceed2.Click();
                    Thread.Sleep(3000);
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Error";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on create account";
            }
              return _result;
        }

        public bool ValidateAccountCreate()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(2000);
                util.WaitForElementVisible(pagePayment, 5);
                if (pagePayment.Displayed)
                {
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Error";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on create account";
            }
            return _result;
        }

        public void ConfirmPaymentOrder()
        {

            //TENTEI VALIDAR O VALOR, PORÉM NÃO CONSEGUI DESTA FORMA

           // var priceTest = "$18.51";
            try
            {
                Thread.Sleep(4000);
                //string price = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//td[@id='total_price_container']//span")).GetAttribute("text");

               // if (price.ToLower().Trim().Equals(priceTest))
                //{
                    ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@id='HOOK_PAYMENT']//div[1]//div/p")).Click();
                    Thread.Sleep(3000);
                    ClassDriver.GetInstance().Driver.FindElement(By.XPath("//p[@class='cart_navigation clearfix']//button")).Click();
               // }
               
            }
            catch
            {

            }
        }


        public bool Finish()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(3000);
                util.WaitForElementVisible(msgConfirm, 5);

                if (msgConfirm.Displayed)
                {
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
