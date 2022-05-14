Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](FirstAutotest/Features/Calculator.feature)
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

@PriceCheckWhenComparingPC
Scenario:Price Check When Comparing PC
	Given Cklik on the button Log in  head Site
	Then Enter the requireds Data in the fields
	Then Cklik on the button log in below margins
	Then In the category section, select Computer
	Then Click on DeskTops
	Then Sort PC alphabetically
	Then Click on the first PC
	Then Click on the button Add to compare list

	@SendAmessageToTheAdministration
Scenario: Send a message to the administration
	Then Click on the Log in button
	Then Enter information into fields
	Then Click on the Sign in button below the fields
	Then In the footer of the site, click on the link Contact us
	Then Write a message in the Inquiry field
	Then Click on the Submit button

	@CheckForBrokenLinks
Scenario: Check for broken links
	Given Click on Sign in in the header of the site
	Then Enter data in the fields
	Then click on the Sign in button below the fields
	Then in the footer of the site in the 4th column, click on the links YouTube, Twitter, Facebook