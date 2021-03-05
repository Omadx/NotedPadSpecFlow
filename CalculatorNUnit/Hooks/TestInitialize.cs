using CalculatorNUnit.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorNUnit.Hooks
{
    [Binding]
    public class TestInitialize
    {
        public const string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;

        [BeforeScenario]
        public void TestSetup()
        {
            AppiumOptions Options = new AppiumOptions();
            Options.AddAdditionalCapability("app", "C:\\Windows\\System32\\notepad.exe");
            Options.AddAdditionalCapability("deviceName", "WindowsPc");
            BasePage.DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), Options);
           //Assert.IsNotNull(DesktopSession);
        }
    }
}
