





https://github.com/user-attachments/assets/853f94f9-22d1-4af6-a910-2fc5c9b9d364






# Math Expression Evaluator

This is a simple Math Expression Evaluator that allows you to enter mathematical expressions and evaluate them in various operations such as addition, subtraction, multiplication, division, modulus, power, and trigonometric functions (sin, cos, tan).

## Features

- Evaluate basic arithmetic operations: addition, subtraction, multiplication, division, modulus, and exponentiation.
- Evaluate trigonometric operations: sine, cosine, and tangent.
- Easy-to-use CLI interface for entering expressions.

## Installation

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/mohamed-osamaaa/Math_Expression_Evaluator.git
   ```

2. Navigate to the project directory:

   ```bash
   cd Math_Expression_Evaluator
   ```

3. Open the project in your preferred IDE or editor.

4. Build and run the project.

## Usage

To use the Math Expression Evaluator, run the application and enter a math expression in the console, like:

- `5 + 3`
- `10 * 2`
- `sin 30`
- `pow 2 3`

The program will evaluate the expression and print the result.

## Example

```
Please enter math expression: 5 + 3
Left Side = 5, Operation = Addition, Right Side = 3
5 + 3 = 8
```

## Files

- `Program.cs`: The main entry point for the application.
- `App.cs`: Contains the logic for running the math expression evaluation loop.
- `ExpressionParser.cs`: Parses the user input and converts it into a `MathExpression` object.
- `MathExpression.cs`: Represents a math expression with operands and operation.
- `MathOperation.cs`: Contains the enumeration for various math operations.
