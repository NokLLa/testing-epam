using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace TESTPOLAST.Driver
{
    public class DriverSingleton
    {
        private static WebDriver driver;
        private DriverSingleton() {}
        public static WebDriver getDriver()
        {
            if (null == driver)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver("C:/Program Files/Google/Chrome/Application");
            }
            return driver;
        }
        public static void CloseDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
