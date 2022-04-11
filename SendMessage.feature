Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Task4/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@SendAmessageToTheAdministration
Scenario: Send a message to the administration
	Then Click on the Log in button
	Then Enter information into fields
	Then Click on the Sign in button below the fields
	Then In the footer of the site, click on the link Contact us
	Then Write a message in the Inquiry field
	Then Click on the Submit button
