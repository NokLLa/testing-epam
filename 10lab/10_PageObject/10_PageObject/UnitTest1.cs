using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using _10_PageObject.pages;


namespace _10_PageObject
{
    public class Tests
    {
        IWebDriver ChromeBrowser;
        [SetUp]
        public void Setup()
        {
            ChromeBrowser = new OpenQA.Selenium.Chrome.ChromeDriver();
            ChromeBrowser.Manage().Window.Maximize();
            ChromeBrowser.Navigate().GoToUrl("https://libcat.ru/");
        }

        [Test]
        public void Test1()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();


            PageFactory.InitElements(ChromeBrowser, libcatMainPage);
            libcatMainPage.searchInput.SendKeys("Пенелопа Уорд");
            libcatMainPage.searchButton.Click();
        }
        
        [Test]
        public void Test2()
        {
            LibcatMainPage libcatMainPage = new LibcatMainPage();
            LibcatBookPage libcatBookPage = new LibcatBookPage();
            LibcatLoginPage libcatLoginPage = new LibcatLoginPage();


            PageFactory.InitElements(ChromeBrowser, libcatMainPage);
            libcatMainPage.guestButton.Click();
            libcatMainPage.guestMenuLoginButton.Click();


            PageFactory.InitElements(ChromeBrowser, libcatLoginPage);
            libcatLoginPage.loginInput.SendKeys("Nk112");
            libcatLoginPage.passwordInput.SendKeys("123123Add");
            libcatLoginPage.loginButton.Click();


            PageFactory.InitElements(ChromeBrowser, libcatMainPage);
            libcatMainPage.bookLinkButton.Click();


            PageFactory.InitElements(ChromeBrowser, libcatBookPage);
            libcatBookPage.reviewsButton.Click();
            libcatBookPage.reviewsInput.SendKeys("Советую эту книгу");
            libcatBookPage.sendCommentButton.Click();
        }
    }
}