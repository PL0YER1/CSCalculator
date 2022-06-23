// Guide to making a calculator in C#
// Please use reference
// https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022

using System;

double num1 = 0; // has to be null so input can be added without false values returned
double num2 = 0; // highlight over ToInt32(now ToDouble) for more info

Console.WriteLine("   Calculator in C#   ");
Console.WriteLine("-----------------------\n"); // Heading

Console.WriteLine("Enter a number and press enter");
//num1 = Convert.ToInt32(Console.ReadLine());
num1 = Convert.ToDouble(Console.ReadLine());
// waits for users to input a number

Console.WriteLine("Enter another number");
//num2 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToDouble(Console.ReadLine());
// waits for another number

Console.WriteLine("Choose an option from the list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");
// What mathimatical formula the users wants

switch (Console.ReadLine())
{
    // read above
    // $ needed so it can take the values from num1 & num2 and input it into the console
    // would return {num1} + {num2} = without it
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        while (num2 == 0)
        // Asks user to enter a value that is not 0
        // This will stop bugs from returning false positives
        {
            Console.WriteLine("Enter a non-zero divisor ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

// Wait for a response before closing
Console.Write("Press any key to exit");
Console.ReadKey();
