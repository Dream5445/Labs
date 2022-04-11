Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Task_1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Registratio
Scenario: Registration on the site
	Given Clik on the button Registration
	Then Fill in the data fields
		| First Name | Last Name | Email                        | Password | Confirm Password |
		| Artem      | Oleynik   | artem.oleynik.2126@gmail.com | qwerty   | qwerty           |
	Then Click on the Registers

@Authorization
Scenario: Authorization on the site
Given Cklik on the button Sigh in 
Then Fill in the data field
	| Email                        | Password |
	| artem.oleynik.2126@gmail.com | qwerty   | 
Then Cklik on the button sigh in 