Feature: NotepadFeature
	Simple Notepad for adding two text

@mytag
Scenario: Add simple text 
	Given I open the application
	And Write simple text
	Then Close app

@mytag2
Scenario: Replace text 
	Given I open the application
	And Replace With Input
	Then Close app

@mytag3
Scenario: Get Date Notepad 
	Given I open the application
	And Get date
	Then Close app