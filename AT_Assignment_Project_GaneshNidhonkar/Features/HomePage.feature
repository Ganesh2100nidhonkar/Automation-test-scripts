Feature: Home Page

  Scenario: Navigate to login page from home page
    Given I am on the home page
    When I click on the login link
    Then I should be navigated to the login page

  Scenario: Navigate to register page from home page
    Given I am on the home page
    When I click on the register link
    Then I should be navigated to the register page

  Scenario: Search for a product
    Given I am on the home page
    When I enter "Laptop" in the search bar
    And I click the search button
    Then I should see search results for "Laptop"

  Scenario: Log out
    Given I am on the login page
    When I click the log out link
    Then I should be navigated to the home page

  Scenario: Add product to wishlist
    Given I am on the home page
    When I click on the wishlist link
    Then I should be navigated to the wishlist page