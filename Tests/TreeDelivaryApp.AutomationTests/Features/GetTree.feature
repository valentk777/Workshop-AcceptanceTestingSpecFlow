@TreeOrder
Feature: Tree can be ordered
	As a user
	I want to order a tree

Scenario: Tree is ordered successfully
	Given Open application web page
	When Fill tree order form with valid tree name test1, valid tree type 1 and delivery adress Brivibas
	When Press submit button
	Then Ordered successfully
	Then Close web page

