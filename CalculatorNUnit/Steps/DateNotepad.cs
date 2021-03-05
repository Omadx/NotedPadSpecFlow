using CalculatorNUnit.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorNUnit.Steps
{
    [Binding]
    public class DateNotepad
    {
        ExecuteNote executeNote = new ExecuteNote();

        [Given(@"Get date")]
        public void GivenGetDate()
        {
            executeNote.EnterTimeAndDataTest();
        }

    }
}
