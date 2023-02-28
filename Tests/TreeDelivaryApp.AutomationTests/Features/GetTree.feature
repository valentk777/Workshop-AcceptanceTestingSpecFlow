@TreeOrder @asd
Feature: Tree can be ordered
	As a user
	I want to order a tree

Scenario: Tree is ordered successfully
#Step 1 Fill the form
	When Fill tree order form with valid tree name test1, valid tree type 1 and delivery adress Brivibas
	And Press submit button
	Then Ordered successfully