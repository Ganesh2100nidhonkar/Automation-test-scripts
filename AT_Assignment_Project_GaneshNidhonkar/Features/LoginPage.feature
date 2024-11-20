Feature: Login Page

  Scenario: Log in with valid credentials
    Given I am on the login page
    When I enter the email "test@example.com"
    And I enter the password "Password123"
    And I click the login button
    Then I should be navigated to the account page

  Scenario: Log in with invalid credentials
    Given I am on the login page
    When I enter the email "wrong@example.com"
    And I enter the password "WrongPassword"
    And I click the login button
    Then I should see an error message indicating invalid credentials

  Scenario: Navigate to password recovery page
    Given I am on the login page
    When I click on the "Forgot password" link
    Then I should be navigated to the password recovery page