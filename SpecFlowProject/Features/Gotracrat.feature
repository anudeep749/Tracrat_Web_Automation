Feature: Gotracrat Automation Testing

Scenario: Validating features of Gotracrat
    Given the User navigates to the Gotracrat website
    When the User logs in with valid credentials
    And the User selects 'Select Company'
    #And the User performs a random selection in the Company List
    And the User Selected the 'ABC POWER COMPANY' in the Company List
    And the User click on 'Manage Companies'
    And the User clicks on 'Add Company'
    And the User enters the Company Name as 'CyberTowers2'
    And the User clicks on the save button
    #And the User selects a randomly added Company
    And the User selected the recently selected Company 
    And the User clicked on 'Manage Companies'
    And the User enters the search Text
    Then the User validates the Text in the search bar matches the entered text
    