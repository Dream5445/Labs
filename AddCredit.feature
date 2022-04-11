Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Task5-6/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@FillInTheDataFromTheBankCardAndDeleteThem
Scenario: Fill in the data from the bank card and delete them
	Given Click on the Sign In button in the header of the site
	Then Enter your details in the field
	Then Click on the Sign In button below the fields
	Then in the category choose gift card
	Then Add a card with the name Click on the card with the name $100 Physical Gift Card to the cart
	Then Enter a name in the Recipient's Name field and click on the Add to card button
	Then click on category books
	Then add the first book to the cart
	Then Select a computer in the category
	Then Click on laptop
	Then Click on the Add to card button
	Then In category choose Jewelery
	Then Adding a product with the name Black & White Diamond Heart to the cart
	Then Click in the header of the site on the Shopping cart
	Then We put a bird in front of the offer I agree with the terms of service and I adhere to them unconditionally (read)
	Then  Click on the button Chekout
	Then fill in all required fields
	Then Put a tick in front of the offer In-Store Pickup
	Then Click on the Continue button
	Then Choose a payment method Credit card
	Then Click on the Continue button
	Then select a credit card in the combobox
	Then Fill in the fields with data from the credit card
	Then Removing data from fields

