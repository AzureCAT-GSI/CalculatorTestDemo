# Calculator Test Demo
This is a demo application demonstrating the effective use of Unit Tests.

There are three branches, each with exactly the same functionality, but with key differences.

##[HardToTest](https://github.com/GSIAzureCOE/CalculatorTestDemo/tree/HardToTest)
Branch with a code structure that is hard to test because of dependencies.

##[EasyToTest](https://github.com/GSIAzureCOE/CalculatorTestDemo/tree/EasyToTest)
Branch with a code structure that is easy to test because dependencies are handled through interfaces that can be replaced by other implementations (such as stubs or mocks).

##[WithTests](https://github.com/GSIAzureCOE/CalculatorTestDemo/tree/WithTests)
Branch with the same code as the [EasyToTest](https://github.com/GSIAzureCOE/CalculatorTestDemo/tree/EasyToTest) branch, but with tests added for most operations.
