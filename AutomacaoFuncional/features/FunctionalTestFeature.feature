Feature: C-FunctionalTestFeature
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 Default: Chrome

@AcessPage
Scenario: Access Page
Given Access to page "http://automationpractice.com/index.php"	
Then Page loaded with sucess


@Select_Product
Scenario: Select Product
Given Click on product
When Click add cart
And  Click on proceed to checkout
Then Verify product "Faded Short Sleeve T-shirts"

@SignUp_Page_and_Finish
Scenario: SignUp Page And Finish
Given Add email and click create account
When add the personal informations
And Validate adress and proceed
Then Create account successfully
When Confirm payment and order
Then Finish
