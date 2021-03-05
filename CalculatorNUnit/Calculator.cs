using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CalculatorNUnit
{
    public class Calculator
    {
        public const string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;

        [SetUp]
        public void Setup()
        {
            AppiumOptions Options = new AppiumOptions();
            Options.AddAdditionalCapability("app", "Microsoft.BingWeather_8wekyb3d8bbwe!App");
            Options.AddAdditionalCapability("deviceName", "WindowsPc");
            DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), Options);
            //DesktopSession.FindElementByAccessibilityId("num5Button").Click();
            Assert.IsNotNull(DesktopSession);
        }
        [Test]
        public void HelloCalculator()
        {
            //DesktopSession.FindElementByAccessibilityId("num5Button").Click();
            WindowsElement ButtonEight = DesktopSession.FindElementByName("Buscar una ciudad");
            ButtonEight.SendKeys("granada");
            WindowsElement EnterButton = DesktopSession.FindElementByName("Buscar");
            EnterButton.Click();
            //WindowsElement DetailsButton = DesktopSession.FindElementByName("Detalles");
            //DetailsButton.Click();
            Console.WriteLine("es ", ButtonEight.Text);
        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(5000);
            DesktopSession.CloseApp();
        }
    }
}
