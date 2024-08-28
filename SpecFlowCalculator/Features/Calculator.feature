Feature: Calculator
Simple Calculator implementations for trying basic functions

@calculator @regression @practice 

Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

	Scenario: Subtract two numbers
	Given the first number is 90
	And the second number is 120
	When the two numbers are subtracted
	Then the result should be -30

	Scenario: Multiply two numbers
	Given the first number is 30
	And the second number is 30
	When the two numbers are multiplied
	Then the result should be 900

	Scenario: Divide two numbers
	Given the first number is 180
	And the second number is 20
	When the two numbers are divided
	Then the result should be 9
