using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Firefox;
using System.Numerics;

namespace NUnitTestAptimeaLappolainen
{
    public class Tests
    {

        IWebDriver driver;
        String test_url = "https://karlstevenmellikov.wordpress.com/";
        private readonly Random _random = new Random(); 

        [SetUp]
        public void start_browser() 
        {
            driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\asd\\new\\new\\drivers\\geckodriver.exe");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_page1()
        {
            driver.Url = test_url;
            driver.Navigate().GoToUrl("https://karlstevenmellikov.wordpress.com/");

            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-54']")); sButton2.Click(); } catch (Exception) { }

            /*for (int a = 0; a < 1; a++)
            {
                Thread.Sleep(2500);
                var sRadio = driver.FindElements(By.XPath("//div[@class='fieldset-wrapper']"));
                for (int i = 0; i < sRadio.Count; i++)
                {
                    var els = sRadio[i].FindElements(By.XPath(".//input[@type='radio']"));
                    if (els.Count >= 2)
                    {
                        try { els[_random.Next(0, els.Count)].Click(); } catch (Exception) { }
                    }
                }
                var sText = driver.FindElements(By.XPath("//input[@type='text']"));
                for (int i = 0; i < sText.Count; i++)
                {
                    try { sText[i].Click(); sText[i].SendKeys("Lappolainen"); } catch (Exception) { }
                }
                var sTextArea = driver.FindElements(By.XPath("//textarea"));
                for (int i = 0; i < sTextArea.Count; i++)
                {
                    try { sTextArea[i].Click(); sTextArea[i].SendKeys("LappolainenMartin"); } catch (Exception) { }
                }
                var sNum = driver.FindElements(By.XPath("//input[@type='number']"));
                for (int i = 0; i < sNum.Count; i++)
                {
                    try { sNum[i].Click(); sNum[i].SendKeys("1"); } catch (Exception) { }
                }
                var sSelect = driver.FindElements(By.XPath("//select"));
                for (int i = 0; i < sNum.Count; i++)
                {
                    try { sSelect[i].Click(); sSelect[i].FindElements(By.XPath(".//*"))[2].Click(); } catch (Exception) { }
                }

                IWebElement sButtonE = driver.FindElement(By.XPath("//*[@value='Sauvegarder brouillon']"));
                try { sButtonE.Click(); } catch (Exception) { }
                Thread.Sleep(2500);
                IWebElement sButton = driver.FindElement(By.XPath("//*[@value='Suivant']"));
                try { sButton.Click(); } catch (Exception) { }
            }
            Thread.Sleep(2500);

            IWebElement sButton3 = driver.FindElement(By.XPath("//*[@value='Finaliser']"));
            try { sButton3.Click(); } catch (Exception) { }

            Thread.Sleep(2500);

            IWebElement sButton4 = driver.FindElement(By.XPath("//a[@href='/user/login']"));
            try { sButton4.Click(); } catch (Exception) { }

            Thread.Sleep(2500);

            IWebElement sButton5 = driver.FindElement(By.XPath("//*[@value='Se connecter']"));
            try { sButton5.Click(); } catch (Exception) { }
            Thread.Sleep(8000);*/
        }
        //[TearDown]
        //public void close_Browser()
        //{
        //    driver.Quit();
       // }
    }
}
