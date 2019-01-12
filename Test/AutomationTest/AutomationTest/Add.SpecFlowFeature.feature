Feature: Add two numbers
		two numbers should be added.
		If number not given should be considered as 0


@Empty-Input
Scenario Outline: Add empty numbers
Given first number <firstNumber>
And second number <secondNumber>
When clicked Add
Then Output should be <result>
Examples: 
| firstNumber | secondNumber | result |
|             |              | 0      |
|             |       0      | 0      |
|         0   |              | 0      |
|       100   |              | 100    |
|             |       50     | 50     |

@Negative-Input
Scenario Outline: Add Negative numbers
Given first number <firstNumber>
And second number <secondNumber>
When clicked Add
Then Output should be <result>
Examples: 
| firstNumber | secondNumber | result |
|      -100   |   -10        | -110   |
|       100   |   -10        |  90    |
|      -100   |   10         | -90    |
|       100   |    -200      | -100   |