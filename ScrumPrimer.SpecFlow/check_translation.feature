Feature: check_translation
	In order to read a scrum primer
	As a foreign people
	I want to see scrum primer in my own language

@mytag
Scenario: Default translation language
	Given I am on the home page
	When I go to scrum primer overview translation page
	Then I will see scrum primer overview in 'zh-cn'
