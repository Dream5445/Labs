Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Task7/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@CheckForBrokenLinks
Scenario: Check for broken links
	Given Click on Sign in in the header of the site
	Then Enter data in the fields
	Then click on the Sign in button below the fields
	Then in the footer of the site in the 4th column, click on the links YouTube, Twitter, Facebook