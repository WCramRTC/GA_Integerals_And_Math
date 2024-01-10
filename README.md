# Guided Assignment: Integral Types and Math Operations in C#

## Introduction
Integral types in C# are data types used to represent whole numbers, both positive and negative, without any fractional or decimal parts. These types are used for a wide range of purposes in programming, such as counting, indexing, and performing various mathematical calculations where decimal precision is not required. Integral types are essential for working with integer values efficiently.

Here is a table that summarizes the common integral types in C# along with their ranges:

| Data Type    | Size (in Bits) | Range                              | Description                                       |
|--------------|----------------|------------------------------------|---------------------------------------------------|
| sbyte        | 8              | -128 to 127                        | Signed 8-bit integer                              |
| byte         | 8              | 0 to 255                           | Unsigned 8-bit integer                            |
| short        | 16             | -32,768 to 32,767                  | Signed 16-bit integer                             |
| ushort       | 16             | 0 to 65,535                        | Unsigned 16-bit integer                           |
| int          | 32             | -2,147,483,648 to 2,147,483,647    | Signed 32-bit integer                             |
| uint         | 32             | 0 to 4,294,967,295                | Unsigned 32-bit integer                           |
| long         | 64             | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | Signed 64-bit integer |
| ulong        | 64             | 0 to 18,446,744,073,709,551,615    | Unsigned 64-bit integer                           |


These integral types provide flexibility in choosing the appropriate data type for specific use cases, depending on the range and precision of integer values you need to work with in your C# program.

---

## Requirements

#### Project Setup (15 Points)
- Create a new console application named `GA_IntegralMath_YourName`.
- Ensure the project is properly set up with `Program.cs`.

#### Exploration of Integral Types (25 Points)
- Declare various integral types (`int`, `long`, `byte`, `short`, etc.) and explain their purpose and range.
- Provide clear examples showcasing the use of each integral type.

#### Implementation of Basic Math Operations (25 Points)
- Implement and thoroughly explain basic arithmetic operations (addition, subtraction, multiplication, division, modulus) using integral types.
- Include multiple examples for each arithmetic operation.

#### Complex Math Operations Using Integral Types (25 Points)
- Develop and explain complex mathematical expressions that combine different arithmetic operations.
- Use examples to demonstrate the correct application of the order of operations (PEMDAS).

#### Code Testing and Validation (15 Points)
- Test all basic and complex operations in the `Main` method.
- Validate the results with detailed explanations.

#### Code Readability and Documentation (15 Points)
- Write well-organized and readable code.
- Include comprehensive comments explaining the logic and purpose of the code.

#### Submission (5 Points)
- Successfully upload the complete project to GitHub.
- Ensure the repository is public and contains all necessary files.
- Submit the correct GitHub repository link in Canvas.

#### Total (100 Points)
- Each section is mandatory and points are awarded based on fulfilling each detailed requirement accurately.

---

### Starting Code
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exploring C# Integral Types and Math Operations");
        // Additional implementation will follow
    }
}
```

---

## Step-by-Step Implementation

### **Step 1: Exploration of Integral Types**

Declare various integral types, explaining their range and purpose.

```csharp
int myInt = 2147483647; // Int32: Ranges from -2,147,483,648 to 2,147,483,647. Commonly used for general counting.
long myLong = 9223372036854775807L; // Int64: Larger range for big numbers, from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
byte myByte = 255; // Byte: Ranges from 0 to 255, often used for small counts or data manipulation.
short myShort = 32767; // Int16: Useful for numbers between -32,768 and 32,767, when int is more than needed.
```

### **Step 2: Basic Math Operations**

Implement basic arithmetic operations with explanations.

```csharp
int sum = myInt + 100; // Addition: Combines two numbers into a larger sum.
int difference = myInt - 50; // Subtraction: Removes a quantity from another.
int product = myShort * 2; // Multiplication: Scales a number by another number.
int quotient = myInt / 2; // Division: Splits a number into equal parts.
int remainder = myByte % 10; // Modulus: Finds the remainder after division.
```

Please write and display the results of the following equations in the table.

| Equation (Code Representation)                      | Result |
|-----------------------------------------------------|--------|
| `int result1 = 5 + 3; // Console.WriteLine(result1)` | 8      |
| `int result2 = 10 - 4; // Console.WriteLine(result2)`| 6      |
| `int result3 = 7 * 2; // Console.WriteLine(result3)` | 14     |
| `int result4 = 20 / 4; // Console.WriteLine(result4)`| 5      |
| `int result5 = 9 % 2; // Console.WriteLine(result5)` | 1      |
| `int result6 = 15 + 6; // Console.WriteLine(result6)`| 21     |
| `int result7 = 12 - 7; // Console.WriteLine(result7)`| 5      |
| `int result8 = 4 * 3; // Console.WriteLine(result8)` | 12     |
| `int result9 = 30 / 5; // Console.WriteLine(result9)`| 6      |
| `int result10 = 16 % 3; // Console.WriteLine(result10)`| 1    |
| `int result11 = 8 + 10; // Console.WriteLine(result11)`| 18   |
| `int result12 = 20 - 8; // Console.WriteLine(result12)`| 12   |
| `int result13 = 6 * 7; // Console.WriteLine(result13)`| 42    |
| `int result14 = 45 / 9; // Console.WriteLine(result14)`| 5    |
| `int result15 = 25 % 4; // Console.WriteLine(result15)`| 1    |


### **Step 3: Complex Math Operations**

Create complex mathematical expressions using integral types.

```csharp
// Assuming the declarations of 'number' and 'shortNumber' variables
int number = 20; // Example value
short shortNumber = 30; // Example value

int complexOperation1 = (number / 2) + 3 * shortNumber; // Combines division, multiplication, and addition.
// Explanation: First, 'number' is divided by 2, then the result is multiplied by 3 and added to 'shortNumber'.

int complexOperation2 = 5 * (shortNumber - 1000) / 2; // Combines subtraction, multiplication, and division.
// Explanation: First, 'shortNumber' is subtracted by 1000, then the result is multiplied by 5 and divided by 2.

```

A complex mathematical operation refers to an expression that combines multiple arithmetic operations in a single statement. Unlike simple operations that involve just one kind of arithmetic (like addition, subtraction, multiplication, or division), complex operations mix several of these. They often require careful consideration of the order in which the operations are performed, adhering to the standard rules of arithmetic order (PEMDAS/BODMAS).

### Key Components of Complex Mathematical Operations:

1. **Multiple Arithmetic Operations**: Involves a combination of addition, subtraction, multiplication, division, and possibly modulus operations.

2. **Use of Parentheses**: Parentheses are often used to group certain parts of the expression, influencing the order of operations. Operations inside parentheses are performed first.

3. **Order of Operations (PEMDAS/BODMAS)**:
   - **P/B** - Parentheses/Brackets
   - **E/O** - Exponents/Orders (like square roots)
   - **MD/DM** - Multiplication and Division (left-to-right)
   - **AS** - Addition and Subtraction (left-to-right)

4. **Variables and Constants**: These operations can involve both variables (which can change values) and constants (fixed values).

### Example of a Complex Mathematical Operation in C#:

```csharp
int a = 5;
int b = 10;
int c = 2;

int complexOperation = (a + b) * c - a / c;
// Breakdown:
// 1. Parentheses first: (a + b) = 15
// 2. Multiplication: 15 * c = 30
// 3. Division: a / c = 2
// 4. Subtraction: 30 - 2 = 28
```

In this example, the expression `(a + b) * c - a / c` is a complex mathematical operation. It involves addition, multiplication, division, and subtraction. The operation is executed following the rules of PEMDAS/BODMAS to arrive at the correct result. 

Complex operations are fundamental in various programming tasks, particularly in scenarios involving mathematical calculations, data analysis, and algorithm development. Understanding how to construct and deconstruct these operations is crucial for accurate and efficient programming.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Complex Equation: (3 + 2) * 5 - 4 / 2 + 6
        // According to PEMDAS, the operations will be performed in the following order:
        // 1. Parentheses (3 + 2)
        // 2. Multiplication and Division (from left to right)
        // 3. Addition and Subtraction (from left to right)

        int result = (3 + 2) * 5 - 4 / 2 + 6;

        Console.WriteLine("Result of the complex equation: " + result);
        // Expected output: 29
        // Explanation:
        // Step 1: (3 + 2) = 5
        // Step 2: 5 * 5 = 25
        // Step 3: 4 / 2 = 2
        // Step 4: 25 - 2 = 23
        // Step 5: 23 + 6 = 29
    }
}
```



| Equation (Code Representation)                                    | Result |
|-------------------------------------------------------------------|--------|
| `int result1 = (5 + 3) * 2; // Console.WriteLine(result1)`        | 16     |
| `int result2 = (10 - 4) + 7 * 3; // Console.WriteLine(result2)`   | 27     |
| `int result3 = 7 * (2 + 6) / 4; // Console.WriteLine(result3)`    | 14     |
| `int result4 = (20 / 4) + 15 - 3; // Console.WriteLine(result4)`  | 20     |
| `int result5 = (9 % 2) + 12 / 4; // Console.WriteLine(result5)`   | 4      |


### **Step 4: Testing and Validation**

Test each operation and equation in the `Main` method.

```csharp
Console.WriteLine($"Equation 1 Result: {equation1}");
Console.WriteLine($"Equation 2 Result: {equation2}");
```

### **Step 5: Submission**

- Review and organize your code.
- Upload to GitHub and submit the link in Canvas.

---

## Revised Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Correct project creation and setup. | 15 |
| **Integral Types Exploration** | Detailed explanation and examples of integral types. | 25 |
| **Basic Math Operations** | Correct implementation and in-depth explanation. | 25 |
| **Complex Math Operations** | Accurate execution of complex expressions with explanations. | 25 |
| **Code Testing and Validation** | Effective testing, validation, and explanation of results. | 15 |
| **Code Readability** | Well-organized and documented code. | 15 |
| **Submission** | Proper GitHub upload and submission. | 5 |
| **Total** |  | 100 |

