@ignore
Feature: This feature is ignored

	Scenario: Add new tree to the shop
	When Fill tree order form with valid tree name test1, valid tree type 1 and delivery adress Brivibas
	And Press submit button
	Then Ordered successfully