Feature: EmployeeExperience

As a user,
I was to see employee experience,
So that I can learn how to adapt my workpoint configuration using Spanish Point's Services.

@tag1
Scenario: Teat employee experience tab
	Given On homepage
	When Click Accept all cookies
	When Hover Over Solution & Services
	When Click Modern Work
	When Click Employee Experience tab
	Then Assert Employee Experience details
