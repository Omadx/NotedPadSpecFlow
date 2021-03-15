using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorNUnit.Pages
{
    public class ExecuteNote : Base.BasePage
    {
        public WindowsElement NotepadTextArea = DesktopSession.FindElementByAccessibilityId("15");
        public WindowsElement EditButton = DesktopSession.FindElementByName("Edició");
        //public WindowsElement ReplaceButton = DesktopSession.FindElementByAccessibilityId("23");
        //public WindowsElement FindWhatInput = DesktopSession.FindElementByAccessibilityId("1152");
        //public WindowsElement ReplaceWithInput = DesktopSession.FindElementByAccessibilityId("1153");
        //public WindowsElement ReplaceAllButton = DesktopSession.FindElementByName("Reemplazar todo");
        //public WindowsElement CancelButton = DesktopSession.FindElementByAccessibilityId("2");
        //public WindowsElement GetDate = DesktopSession.FindElementByAccessibilityId("26");

        public void PerfomrAddition() => NotepadTextArea.SendKeys("Hello World");
        public void ReplaceWord()
        {
            //NotepadTextArea.SendKeys("Hello World");
            EditButton.Click();
            DesktopSession.FindElementByAccessibilityId("23").Click();
            DesktopSession.FindElementByAccessibilityId("1152").SendKeys("World");
            DesktopSession.FindElementByAccessibilityId("1153").Clear();
            DesktopSession.FindElementByAccessibilityId("1153").SendKeys("QA Engineers");
            DesktopSession.FindElementByName("Reemplazar todo").Click();
            DesktopSession.FindElementByAccessibilityId("2").Click();
        }

        public void EnterTimeAndDataTest()
        {
            EditButton.Click();
            DesktopSession.FindElementByAccessibilityId("26").Click();
        }


    }
}
