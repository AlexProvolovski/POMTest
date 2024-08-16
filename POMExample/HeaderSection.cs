using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class HeaderSection : BasePage
    {
        public HeaderSection(IWebDriver driver) : base(driver) { }
        private IWebElement btnLogin => driver.FindElement(By.XPath("//a[@href='/login/']"));

        public LoginPage ClickLogin()
        {
            btnLogin.Click();
            return new LoginPage(driver);
        }
    }
}
