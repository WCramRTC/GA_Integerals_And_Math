namespace GA_Integerals_And_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exploring C# Integral Types and Math Operations");

            // Step 1: Exploration of Integral Types
            int myInt = 2147483647; // Int32: Ranges from -2,147,483,648 to 2,147,483,647.
            long myLong = 9223372036854775807L; // Int64: Larger range for big numbers.
            byte myByte = 255; // Byte: Ranges from 0 to 255.
            short myShort = 32767; // Int16: Useful for smaller numbers.

            // Display the integral type information in a table
            Console.WriteLine("Integral Types Table:");
            Console.WriteLine("| Data Type    | Size (in Bits) | Range                              | Description                                       |");
            Console.WriteLine("|--------------|----------------|------------------------------------|---------------------------------------------------|");
            Console.WriteLine($"| int          | 32             | -2,147,483,648 to 2,147,483,647    | Signed 32-bit integer                             |");
            Console.WriteLine($"| long         | 64             | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | Signed 64-bit integer |");
            Console.WriteLine($"| byte         | 8              | 0 to 255                           | Unsigned 8-bit integer                            |");
            Console.WriteLine($"| short        | 16             | -32,768 to 32,767                  | Signed 16-bit integer                             |");
            Console.WriteLine();

            // Step 2: Basic Math Operations
            int sum = myInt + 100; // Addition
            int difference = myInt - 50; // Subtraction
            int product = myShort * 2; // Multiplication
            int quotient = myInt / 2; // Division
            int remainder = myByte % 10; // Modulus
            Console.WriteLine();

            // Display the results of basic math operations in a table
            Console.WriteLine("Basic Math Operations Table:");
            Console.WriteLine("| Operation                  | Result |");
            Console.WriteLine("|----------------------------|--------|");
            Console.WriteLine($"| Addition (int + 100)      | {sum,-6} |");
            Console.WriteLine($"| Subtraction (int - 50)   | {difference,-6} |");
            Console.WriteLine($"| Multiplication (short * 2) | {product,-6} |");
            Console.WriteLine($"| Division (int / 2)        | {quotient,-6} |");
            Console.WriteLine($"| Modulus (byte % 10)       | {remainder,-6} |");
            Console.WriteLine();

            // Step 3: Complex Math Operations
            int number = 20;
            short shortNumber = 30;

            int complexOperation1 = (number / 2) + 3 * shortNumber;
            int complexOperation2 = 5 * (shortNumber - 1000) / 2;
            Console.WriteLine();

            // Display the results of complex math operations in a table
            Console.WriteLine("Complex Math Operations Table:");
            Console.WriteLine("| Operation                                                  | Result |");
            Console.WriteLine("|------------------------------------------------------------|--------|");
            Console.WriteLine($"| (number / 2) + 3 * shortNumber                             | {complexOperation1,-6} |");
            Console.WriteLine($"| 5 * (shortNumber - 1000) / 2                               | {complexOperation2,-6} |");
            Console.WriteLine();

            // Step 4: Testing and Validation
            int equation1 = (5 + 3) * 2;
            int equation2 = (10 - 4) + 7 * 3;
            Console.WriteLine();

            // Display the results of the provided equations
            Console.WriteLine("Provided Equations Results:");
            Console.WriteLine($"Equation 1 Result: {equation1}");
            Console.WriteLine($"Equation 2 Result: {equation2}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Exploring C# Integral Types and Math Operations");

            // Additional Equations

            // Equation 6: int result6 = 15 + 6;
            int result6 = 15 + 6;
            Console.WriteLine($"Result of Equation 6: {result6}");

            // Equation 7: int result7 = 12 - 7;
            int result7 = 12 - 7;
            Console.WriteLine($"Result of Equation 7: {result7}");

            // Equation 8: int result8 = 4 * 3;
            int result8 = 4 * 3;
            Console.WriteLine($"Result of Equation 8: {result8}");

            // Equation 9: int result9 = 30 / 5;
            int result9 = 30 / 5;
            Console.WriteLine($"Result of Equation 9: {result9}");

            // Equation 10: int result10 = 16 % 3;
            int result10 = 16 % 3;
            Console.WriteLine($"Result of Equation 10: {result10}");

            // Equation 11: int result11 = 8 + 10;
            int result11 = 8 + 10;
            Console.WriteLine($"Result of Equation 11: {result11}");

            // Equation 12: int result12 = 20 - 8;
            int result12 = 20 - 8;
            Console.WriteLine($"Result of Equation 12: {result12}");

            // Equation 13: int result13 = 6 * 7;
            int result13 = 6 * 7;
            Console.WriteLine($"Result of Equation 13: {result13}");

            // Equation 14: int result14 = 45 / 9;
            int result14 = 45 / 9;
            Console.WriteLine($"Result of Equation 14: {result14}");

            // Equation 15: int result15 = 25 % 4;
            int result15 = 25 % 4;
            Console.WriteLine($"Result of Equation 15: {result15}");

            Console.WriteLine();
            Console.WriteLine("Exploring C# Integral Types and Math Operations");

            // Step 2: Basic Math Operations

            // Equation 1: int result1 = (5 + 3) * 2;
            int result1 = (5 + 3) * 2;
            Console.WriteLine($"Result of Equation 1: {result1}");

            // Equation 2: int result2 = (10 - 4) + 7 * 3;
            int result2 = (10 - 4) + 7 * 3;
            Console.WriteLine($"Result of Equation 2: {result2}");

            // Equation 3: int result3 = 7 * (2 + 6) / 4;
            int result3 = 7 * (2 + 6) / 4;
            Console.WriteLine($"Result of Equation 3: {result3}");

            // Equation 4: int result4 = (20 / 4) + 15 - 3;
            int result4 = (20 / 4) + 15 - 3;
            Console.WriteLine($"Result of Equation 4: {result4}");

            // Equation 5: int result5 = (9 % 2) + 12 / 4;
            int result5 = (9 % 2) + 12 / 4;
            Console.WriteLine($"Result of Equation 5: {result5}");
        } // main

    } // class

} // namespace
