using CalculatorNUnit.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorNUnit.Steps
{
    [Binding]
    public class NotepadStep
    {
        ExecuteNote executeNote = new ExecuteNote();

        [Given(@"I open the application")]
        public void GivenIOpenTheApplication()
        {
            //executeNote.PerfomrAddition();
            //ScenarioContext.Current.Pending();
        }
        [Given(@"Write simple text")]
        public void GivenWriteSimpleText()
        {
            executeNote.PerfomrAddition();
        }

        [Then(@"Close app")]
        public void ThenCloseApp()
        {
            Console.WriteLine("Test Completed!!!");
        }












    }
}
