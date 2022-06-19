
//Brayden Dunn C# calculator for assessment 3 SDV503    

// Declaring the variables and then initializing them to zero
int num1 = 0; int num2 = 0;

//Text inside the application to denounce what it is.  
Console.WriteLine("C#_Calculator by Brayden Dunn 2022\r");
Console.WriteLine("This calculator is capable of addition, subtraction, division and multiplication.");
//Console.ReadLine();
//Here to allow the text to be seperated for better text reading.
Console.WriteLine();

Console.WriteLine("Please note that your specified value(s) cannot exceed 2.1 billion.");
Console.WriteLine();

/* User input for the first number. Note because it's a 32bit integer the target value specified
cannot exceed above 2,147,483,647.
*/

//Usernote for clarity of how to use the application. 
Console.WriteLine("Please Note you input the numbers before choosing how you manipulate them");

//Line break code
Console.WriteLine();

Console.WriteLine("Please insert the first digit(s) below.");
num1 = Convert.ToInt32(Console.ReadLine());

//Line break code
Console.WriteLine();

Console.WriteLine("Please insert the second digit(s) below");
num2 = Convert.ToInt32(Console.ReadLine());

//Line break code
Console.WriteLine();

// User input for what option is to be chosen after they've inserted values. 
Console.WriteLine("What action do you wish to perform?");
Console.WriteLine("\t1 - Add");
Console.WriteLine("\t2 - Subtract");
Console.WriteLine("\t3 - Multiply");
Console.WriteLine("\t4 - Divide");
Console.WriteLine("\t5 - POW");
Console.WriteLine("\t6 -Remainder");
Console.WriteLine("You can also just type the command as a string/word i.e 'Add'. Case sensitive.");

//Switch statement that contains the block of code for the mathmatic calculations.
switch (Console.ReadLine())

{


    case "1":
        Console.WriteLine($"The result: {num1} + {num2} = " + (num1 + num2));
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Black;
        break;

    case "Add":
        Console.WriteLine($"The result: {num1} + {num2} = " + (num1 + num2));
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Black;
        break;

    case "2":
        Console.WriteLine($"The result: {num1} - {num2} = " + (num1 - num2));
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        break;

    case "Subtract":
        Console.WriteLine($"The result: {num1} - {num2} = " + (num1 - num2));
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        break;

    case "3":
        Console.WriteLine($"the result: {num1} * {num2} = " + (num1 * num2));
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Blue;
        break;

    case "Multiply":
        Console.WriteLine($"the result: {num1} * {num2} = " + (num1 * num2));
        Console.BackgroundColor = ConsoleColor.Green; 
        Console.ForegroundColor = ConsoleColor.Blue;
        break;

    case "4":
        Console.WriteLine($"the result: {num1} / {num2} = " + (num1 / num2));
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Blue;
        break;

    case "Divide":
        Console.WriteLine($"the result: {num1} / {num2} = " + (num1 / num2));
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Blue;
        break;

    // the POW calculations. They times the first number by itself then it adds the second number which its times by itself with the first. 
   
    case "5":
        Console.WriteLine($"the result: {num1} * {num1} + {num2} * {num2} = {num1 * num1 + num2 * num2}");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        break;

    case "POW":
        Console.WriteLine($"the result: {num1} * {num1} + {num2} * {num2} = {num1 * num1 + num2 * num2}");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        break;

    //The remainder calculations. Works out much is left over after working out the dividend (num1) by the divisor (num2) and working out 
    //how many whole times num2 goes into num1 and tells you what can't be put in as whole numbers - the remaining numbers.

    case "6":
        Console.WriteLine($"the result: {num1} % {num2} = " + (num1 % num2));
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        break;

    case "Remainder":
        Console.WriteLine($"the result: {num1} % {num2} = " + (num1 % num2));
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        break;
}


//End of the calculator user input. Nothing for the user to do anymore.
Console.WriteLine();
Console.Write("Task completed successfully. Please re-launch for further calculations. ");

