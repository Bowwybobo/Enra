Feature: Registration
	In order to use Gmail
	I need to register

@tc001
Scenario: Valid Login
	Given I Navigate to "https://accounts.google.com/signin/v2/identifier?service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin"
	And I enter a valid email "bowwaanuub@gmail.com"
	And I click on next
	And I enter a valid password "Richie123"
	When I click on next
	Then I should be logged in 


	@tc002
	Scenario: Login with an invalid password
	Given I Navigate to "https://accounts.google.com/signin/v2/identifier?service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin"
	And I enter a valid email "bowwaanuub@gmail.com"
	And I click on next
	And I enter an invalid password "Testing123"
	When I click on next
	#Then I should get an error message


	@tc003
	Scenario: Login with an invalid email and password
	Given I Navigate to "https://accounts.google.com/signin/v2/identifier?service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin"
	And I enter an invalid email "ub@gmail.com"
	When I click on next
	#Then I should get an error message