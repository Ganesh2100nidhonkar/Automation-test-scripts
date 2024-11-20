Feature: Register Page

  Scenario: Register a new user with valid details
    Given I am on the register page
    When I enter the following details
      | FirstName | LastName | Email              | Password | ConfirmPassword |
      | John      | Doe      | johndoe@example.com | Password123 | Password123 |
    And I click the register button
    Then I should see the message "Your registration completed"

  Scenario: Register with existing email
    Given I am on the register page
    When I enter the following details
      | FirstName | LastName | Email              | Password | ConfirmPassword |
      | Jane      | Smith    | johndoe@example.com | Password123 | Password123 |
    And I click the register button
    Then the error message "The specified email already exists"

  Scenario: Register with mismatched passwords
    Given I am on the register page
    When I enter the following details
      | FirstName | LastName | Email              | Password | ConfirmPassword |
      | Alice     | Johnson  | alice@example.com  | Password123 | DifferentPassword |
    And I click the register button
    Then I should see an error message "The password and confirmation password do not match"
