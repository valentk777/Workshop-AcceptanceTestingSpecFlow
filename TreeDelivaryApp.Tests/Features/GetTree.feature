@TreeOrder
Feature: Tree can be ordered
	As a user
	I want to order a tree

Scenario: Tree is ordered successfully
	Given enter valid tree name "test1"
	When press the button "Make an order"
	Then ordered succesfully

Scenario: Tree is ordered wrongly
	Given enter invalid tree name "adb"
	When press the button "Make ad order"
	Then order fails