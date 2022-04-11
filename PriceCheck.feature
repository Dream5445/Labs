Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Task3/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@PriceCheckWhenComparingPC
Scenario:Price Check When Comparing PC
	Given Cklik on the button Log in  head site
	Then Enter the requireds data in the fields
	Then Cklik on the button Log in below margins
	Then In the category section, select Computer
	Then Click on DeskTops
	Then Sort PC alphabetically
	Then Click on the first PC
	Then Click on the button Add to compare list