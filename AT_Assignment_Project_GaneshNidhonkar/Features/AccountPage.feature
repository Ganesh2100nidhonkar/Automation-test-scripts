Feature: Account Page

  Scenario: Update account information
    Given I am on the account page
    When I update my first name to "NewName"
    And I save the changes
    Then I message appeared as "Your account has been updated."

  Scenario: Change password
    Given I am on the account page
    When I change my password from "OldPassword" to "NewPassword"
    And I save the changes
    Then I should see message "Your password has been changed."