using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;

namespace _10_PageObject.pages
{
    internal class LibcatBookPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\'tg-content\']/div/div/div[4]/div/ul/li[5]/a")]
        public IWebElement reviewsButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'comment-editor\']/div/textarea")]
        public IWebElement reviewsInput { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\'dle-comments-form\']/div/div/div/div/button")]
        public IWebElement sendCommentButton { get; set; }
    }
}
