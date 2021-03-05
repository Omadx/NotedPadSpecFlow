using CalculatorNUnit.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorNUnit.Steps
{
    [Binding]
    public class HelloNotepad
    {
        ExecuteNote executeNote = new ExecuteNote();

        [Given(@"Replace With Input")]
        public void GivenReplaceWithInput()
        {
            executeNote.PerfomrAddition();
            executeNote.ReplaceWord();
        }


    }
}
