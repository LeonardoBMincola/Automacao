using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class ProductElementsMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@id='center_column']//div[1]//ul[1]//div//div")]
        [CacheLookup]
        public IWebElement productItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='button lnk_view btn btn - default'][1]")]
        [CacheLookup]
        public IWebElement moreButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='primary_block row']//div[3]/h1")]
        [CacheLookup]
        public IWebElement nameProduct { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@id='add_to_cart']/button")]
        [CacheLookup]
        public IWebElement btnAddCart { get; set; }

        [FindsBy(How = How.ClassName, Using = "icon-ok")]
        [CacheLookup]
        public IWebElement iconCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='button-container']/a/span/i")]
        [CacheLookup]
        public IWebElement btnProceed { get; set; }

        [FindsBy(How = How.Id, Using = "cart_title")]
        [CacheLookup]
        public IWebElement cartTitle { get; set; }



    }
}
