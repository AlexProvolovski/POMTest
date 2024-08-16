using NUnit.Framework;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void LoginWithWrongEmailAndPassword()
        {
            InitPage initPage = new InitPage(driver);


            LoginPage loginPage = initPage.header.ClickLogin();

            loginPage.SetEmail("sdfgdargh");
            loginPage.SetPassword("password");
            Thread.Sleep(3000);
            loginPage.ClickLogin();
            Thread.Sleep(10000);

            var actualErrorMessage = loginPage.GetErrorMessage();
            string expectedErrorMessage = "Неправильное имя пользователя или пароль.";

            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage));
        }
    }
}
