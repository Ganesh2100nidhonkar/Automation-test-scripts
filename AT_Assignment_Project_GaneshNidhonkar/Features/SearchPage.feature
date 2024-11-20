Feature: Search Page

  Scenario: Perform a successful search
    Given I am on the search page
    When I enter "Smartphone" in the search bar
    And I click the search button
    Then I should see search results for "Smartphone"

  Scenario: Perform a search with no results
    Given I am on the search page
    When I enter "NonExistingProduct" in the search bar
    And I click the search button
    Then I should see a message "No products were found that matched your criteria."