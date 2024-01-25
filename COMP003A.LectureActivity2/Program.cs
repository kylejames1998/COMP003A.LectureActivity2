// Author: Kyle James
// Course: COMP003A
// Purpose: Lecture activity for Variables, type system, math, and console properties

using System.Drawing;

namespace COMP003A.LectureActivity2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Working with variables */
            // the following code shows all three primary variable-related activities:
            string username; // declaring a variable
            Console.WriteLine("What is your name?"); // requests user input
            username = Console.ReadLine(); // assigning a value to a variable
            Console.WriteLine("Hi " + username); // retrieving its current value


            // another example of the 3 primary variable related activities
            string favColor;
            Console.WriteLine("What is your favorite color?");
            favColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favColor);


            /* Working with variable integers */
            int score; // declare a new variable with a data type int
            // score = "generic user"; // will fail to compile since because you are assigning a string value to an integer variable
            // score = "0"; // will still fail to compile becuase the "0" is still assigned to a string - enclosed in a double quotes
            score = 0; // works
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;


            /* reading from a variable does not change it */
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The new value of a: " + a);
            Console.WriteLine("The new value of b: " + b);

            /* variables are case-sensitive */
            // the variables below are different despite having similar names
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("**************************************************************");

            // Types of variables and values matter in C#. they are not interchangeable.
            // there are 8 integer types for storing integers of different sizes and ranges: int, short, long, byte, sbyte, uint, ushort, and ulong.
            // The char type stores single characters
            // the string type stores longer text.
            // there are 3 types for storing real numbers: float, double and decimal
            // the bool type store truth values (true and false) used in logic
            // these types are the building block for a much larger type system
            // using var for a variable's type tells the compiler to infer its type from the surrounding code (still has a specific type)
            // the System.Convert class is a useful class to convert from one type to another


            /* declaring and using variables with integer types */
            byte aSingleByte = 34;
            Console.WriteLine("aSinglebyte: " + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSinglebyte: " + aSingleByte);

            short aNumber = 5039;
            Console.WriteLine("aNumber: " + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber: " + aNumber);

            long aVeryBigNumber = 39504282569;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);

            int anInteger = 2147483647;

            /* declaring, using, and concatenating characters and strings */
            char aLetter = 'A'; // character values are enclosed in single quotes
            string message = "Hello world!"; // string values are enclosed in double quotes

            Console.WriteLine("Concatenation using + : " + aLetter + " " + message); // use the + sign in between characters/strings to concatenate
            Console.WriteLine($"Concatenation using string interpolation : {aLetter} {message} ");
            // use string interpolation with a $ before the opening double-quote and enclosing variables with curly braces

            /* Floating-Point types */
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"Vale of number3: {number3}");

            /* Scientific notation */
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Valueof avagadros number: {avogadrosNumber}");

            /* Bool type */
            bool itWorked = true;
            Console.WriteLine($"Value of itWorked: {itWorked}");
            itWorked= false;
            Console.WriteLine($"Value of itWorked: {itWorked}");

            /* Convert */
            string inputAgeString;
            int inputAge;
            int currentYear = 2024;
            Console.WriteLine($"Enter age in {currentYear}: ");
            inputAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Your age is {inputAge}");
            //
            Console.WriteLine("*******************************************************************");

            /* math Operations + , - , * , / , % */
            int addition = 2 + 3;
            int subtraction = 5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition}");
            Console.WriteLine($"Value of subtraction: {subtraction}");
            Console.WriteLine($"Value of multiplication: {multiplication}");
            Console.WriteLine($"Value of division: {division}");
            Console.WriteLine($"Value of modulo: {modulo}");

            // Arithmetic, compound expressions and order of operations
            // Multiplicaton and division are done first, from left to right
            // Addition and subtraction are done last, left to right

            int arithmetic1; // declaring the variable
            arithmetic1 = 9 - 2; //assigning a value to the variable
            Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            arithmetic1 = 3 + 3;
            Console.WriteLine($"new value of arithmetic1: {arithmetic1}");
            int arithmetic2 = 3 + 1; // declaring variable and assigning value at the same time
            Console.WriteLine($"Value of arithmetic 2: {arithmetic2}");
            arithmetic2 = 1 + 2; // assigning new value
            Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

            // use multiple sets of parentheses to group operations
            int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of result: {result}");

            /* compound assignment operator */
            int compoundAsignmentOperator = 0;
            compoundAsignmentOperator += 5; // variable + 5
            compoundAsignmentOperator -= 2; // variable - 2
            compoundAsignmentOperator *= 4; // variable * 4
            compoundAsignmentOperator /= 2; // variable / 2
            compoundAsignmentOperator %= 2; // a is 0 after this line

            /* increment and decrement operators */
            int incrementDecrementOperators = 0;
            incrementDecrementOperators++; // adds 1 to the value
            incrementDecrementOperators--; // subtracts one from the value

            Console.WriteLine("***********************************");
            /* Console 2.0 */
            Console.Write("What is your name, human? "); // notice space at the end
            string userName = Console.ReadLine(); // reads the entire line
            // result: What is your name, human? Kyle

            Console.WriteLine("Press any key when you're ready to begin.");
            Console.ReadKey(); // reads a keystroke

            Console.BackgroundColor = ConsoleColor.Yellow; // changes console background color to yellow
            Console.ForegroundColor = ConsoleColor.Black; // changes text to black
            Console.Title = "Hello World!"; // changes console title

            Console.Beep(440, 1000); // computer beepss
            // dasdas








        }
    }
}