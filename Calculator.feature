Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Task2/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@AddingAnItemToTheCart
Scenario: It is possible to add new item cart
Given Cklik on the button Log in  head site
Then Enter the requireds data in the fields
	| Email                        | Password |
	| artem.oleynik.2126@gmail.com | qwerty   |
Then Cklik on the button Log in below margins
Then Press the button on  first item Add to cart
Then fill in empty field
	| Recipient's Nam	| Recipient's Email |
	| Artem				| artem.oleynik.2126@gmail.com   |
Then push on button add to cart