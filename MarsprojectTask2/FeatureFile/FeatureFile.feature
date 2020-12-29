Feature: Mars portal Share skill and manage listing_FeatureFile

Scenario: Verify whether the user is able to click on Save button in ServiceListing page after entering the details 
	Given I loginto the mars portal
	When  I enter all the details in profile page and click on Share Skills button
	Then  The user should be able to enter details in Share skill page and save them successfully.

Scenario: Verify whether the user is able to edit the details entered and save them successfully.
	 Given I login to the Mars Portal
	 When  I enter profile page and share page details and save them successfully
	 Then  The user should be able to edit the saves details under managing list in Manage listing page.

Scenario: Verify whether the user is able to click on delete button and then on No under manage listing.
	Given I login to the Mars portal
	When  I enter Profile page and share page details and save them successfully,
	And  When i clicked on delete button and no from the pop up, 
	Then The user should see the saved details under manage listing.