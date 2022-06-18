
//Brayden Dunn C# calculator for assessment 3 SDV503    

// Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0;

//Text inside the application to denounce what it is.  
Console.WriteLine("Brayden_Dunn_C#_Calculator\r");
Console.WriteLine("This calculator is capable of addition, subtraction, division and multiplication.");
//Console.ReadLine();
//Here to allow the text to be seperated for better text reading.
Console.WriteLine("              ");

Console.WriteLine("Please note that your specified value(s) cannot exceed 2.1 billion.");
Console.WriteLine("      ");

/* User input for the first number. Note because it's a 32bit integer the target value specified
cannot exceed above 2,147,483,647.
*/

Console.WriteLine("Please insert the first digit(s) below.");
num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please insert the second digit(s) below");
num2 = Convert.ToInt32(Console.ReadLine());

// User input for what option is to be chosen after they've inserted values. 
Console.WriteLine("What action do you wish to perform?");
Console.WriteLine("\t1 - Add");
Console.WriteLine("\t2 - Subtract");
Console.WriteLine("\t3 - Multiply");
Console.WriteLine("\t4 - Divide");
Console.WriteLine("You can also just type the command as a string/word i.e 'Add' The first letter must be capitalized");

//Switch statement that contains the block of code for the mathmatic calculations.
switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine($"The result: {num1} + {num2} = " + (num1 + num2));
        break;

    case "Add": 
        Console.WriteLine($"The result: {num1} + {num2} = " + (num1 + num2));
        break;

    case "2":
        Console.WriteLine($"The result: {num1} - {num2} = " + (num1 - num2));
        break;

    case "Subtract": 
            Console.WriteLine($"The result: {num1} - {num2} = " + (num1 - num2));
        break;

    case "3":
        Console.WriteLine($"the result: {num1} * {num2} = " + (num1 * num2));
        break;

    case "Multiply":
        Console.WriteLine($"the result: {num1} * {num2} = " + (num1 * num2));
        break;

    case "4":
        Console.WriteLine($"the result: {num1} / {num2} = " + (num1 / num2));
        break;

    case "Divide":
        Console.WriteLine($"the result: {num1} / {num2} = " + (num1 / num2));
        break;
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
