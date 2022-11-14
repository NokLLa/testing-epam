using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FunctionalTests
{
    public class Tests
    {
        [Test]
        public void ICanWin()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://pastebin.com";

            driver.FindElement(By.Id("postform-text")).SendKeys("Hello from WebDriver");
            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();
            driver.FindElement(By.Id("postform-name")).SendKeys("helloweb");
            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);

            driver.Close();
        }

        [Test]
        public void BringItOn()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://pastebin.com";
            driver.FindElement(By.Id("postform-text")).SendKeys("git config --global user.name  \"New Sheriff in Town\"" + "\ngit reset $(git commit - tree HEAD ^{ tree} -m \"Legacy code\") " + "\ngit push origin master --force");
            driver.FindElement(By.Id("select2-postform-format-container")).Click();
            driver.FindElement(By.XPath("//li[text()='Bash']")).Click();
            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();
            driver.FindElement(By.Id("postform-name")).SendKeys("how to gain dominance among developers");
            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WebElement syntax = (WebElement)driver.FindElement(By.XPath("//a[text()='Bash']"));
            WebElement codeFirstLine = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[1]/div/span[1]"));
            WebElement codeSecondLine = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[2]/div/span[1]"));
            WebElement codeThirdLine = (WebElement)driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[3]/div/span[1]"));
            Assert.AreEqual("how to gain dominance among developers - Pastebin.com", driver.Title);
            Assert.AreEqual("Bash", syntax.Text);
            Assert.AreEqual("git config", codeFirstLine.Text);
            Assert.AreEqual("git reset", codeSecondLine.Text);
            Assert.AreEqual("git push", codeThirdLine.Text);
            driver.Quit();
        }

        [Test]
        public void LibcatTest()
        {

            IWebDriver ChromeBrowser;

            ChromeBrowser = new ChromeDriver("C:\\driversselenium\\chrome");
            ChromeBrowser.Manage().Window.Maximize();
            ChromeBrowser.Navigate().GoToUrl("https://libcat.ru/");

            IWebElement searchInput = ChromeBrowser.FindElement(By.XPath("//*[@id='tg-header']/div[2]/div/div/div/div/form/fieldset/input[1]"));
            searchInput.SendKeys("�������� ����");

            IWebElement searchButton = ChromeBrowser.FindElement(By.XPath("//*[@id='tg-header']/div[2]/div/div/div/div/form/fieldset/button/i"));
            searchButton.Click();
        }
    }
}