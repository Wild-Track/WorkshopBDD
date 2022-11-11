Feature: CreditCardValidator
	Validate credit card inputs

Scenario: All inputs are good
	Given user fills the three inputs "0123456789012345", "01/2020", "123"
    And credit card number is sixteen digits long
    And expiration date is at format MM/YYYY
    And cvc is three digits long
    When submit button is pressed
    Then user is on page paymentConfirmed

Scenario: Credit card number is not 16 digits long
	Given user fills the three inputs "01234567890123456789", "30/1200", "123"
    And credit card number is not sixteen digits long
    And expiration date is at format MM/YYYY
    And cvc is three digits long
    When submit button is pressed
    Then user is on homePage

Scenario: Expiration is not at format MM/YYYY
	Given user fills the three inputs "0123456789012345", "2020/01", "123"
    And credit card number is sixteen digits long
    And expiration date is not at format MM/YYYY
    And cvc is three digits long
    When submit button is pressed
    Then user is on homePage

Scenario: CVC is not three digits long
	Given user fills the three inputs "0123456789012345", "01/2020", "1234"
    And credit card number is sixteen digits long
    And expiration date is at format MM/YYYY
    And cvc is not three digits long
    When submit button is pressed
    Then user is on homePage