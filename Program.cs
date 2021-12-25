//Calculator Software by Kent Vuong

//Declaring variables then initialize to zero.
int num1 = 0;
int num2 = 0;

//Displaying title as Calculator Software
Console.WriteLine("Calculator Software by Kent Vuong\r");
Console.WriteLine("---------------------------------\n");

//Asking user to type first number.
Console.WriteLine("Please type a number, and then press enter");
num1 = Convert.ToInt32(Console.ReadLine());

//Asking user to type the second number.
Console.WriteLine("Please type an additional number, and press enter");
num2 = Convert.ToInt32(Console.ReadLine());

//Asking user to choose an option.
Console.WriteLine("Please choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Please make a choice. ");

//Use a switch statement to do maths.
switch (Console.ReadLine())
{
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
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

//Waiting for the user to respond before closing.
Console.Write("Please press any key to close the calculator.");
Console.ReadKey();
