using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class SignUpElementsMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group']//input[@id='email_create']")]
        [CacheLookup]
        public IWebElement inputEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='submit']//button")]
        [CacheLookup]
        public IWebElement btnCreate { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='id_gender1']")]
        [CacheLookup]
        public IWebElement gender { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='customer_firstname']")]
        [CacheLookup]
        public IWebElement inputName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='customer_lastname']")]
        [CacheLookup]
        public IWebElement inputLastname { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        [CacheLookup]
        public IWebElement inputPasswrd { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='firstname']")]
        [CacheLookup]
        public IWebElement inputAdressName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='lastname']")]
        [CacheLookup]
        public IWebElement inputAdressLastname { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='address1']")]
        [CacheLookup]
        public IWebElement inputAdress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='city']")]
        [CacheLookup]
        public IWebElement inputCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='id_state']//option[3]")]
        [CacheLookup]
        public IWebElement selectState { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='id_country']")]
        [CacheLookup]
        public IWebElement selectCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='phone_mobile']")]
        [CacheLookup]
        public IWebElement inputPhone { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='alias']")]
        [CacheLookup]
        public IWebElement inputAlias { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='postcode']")]
        [CacheLookup]
        public IWebElement inputZip { get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        [CacheLookup]
        public IWebElement submitAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        [CacheLookup]
        public IWebElement stepTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='cart_navigation clearfix']//button[@class='button btn btn-default button-medium']")]
        [CacheLookup]
        public IWebElement btnProceed { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='cart_navigation clearfix']//button[@class='button btn btn-default standard-checkout button-medium']")]
        [CacheLookup]
        public IWebElement btnProceed2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='checkbox']//input[@id='cgv']")]
        [CacheLookup]
        public IWebElement btnConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[@class='page-heading' and text()='Please choose your payment method']")]
        [CacheLookup]
        public IWebElement pagePayment { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='box']//p//strong[text()='Your order on My Store is complete.']")]
        [CacheLookup]
        public IWebElement msgConfirm { get; set; }


    }
}
