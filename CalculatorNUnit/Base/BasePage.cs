using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorNUnit.Base
{
    public class BasePage
    {
        internal static WindowsDriver<WindowsElement> DesktopSession { get; set; }
    }
}
