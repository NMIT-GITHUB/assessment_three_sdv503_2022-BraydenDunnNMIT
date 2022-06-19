using System.Linq;
Console.WriteLine("Csharp converter by Brayden Dunn\r");
Console.WriteLine("Csharp Conversion from js, takes three arrays and gives back highest from each. Check source for how it works.");
Console.WriteLine("You can change the value of any of the arrays and it will still function");
Console.WriteLine();

//The arrays and their integer values
int[] array1 = { 65, 68, 13 };
int[] array2 = { 64, 11, 99 };
int[] array3 = { 32, 41, 19 };


//Very sloppy arrays management and information on what they do output-ed to the console.
Console.Write(array1[0]);
Console.Write(",");
Console.Write(array1[1]);
Console.Write(",");
Console.WriteLine(array1[2]+ "--First array" );
Console.Write(array2[0]);
Console.Write(",");
Console.Write(array2[1]);
Console.Write(",");
Console.WriteLine(array2[2]+ "--Second array");
Console.Write(array3[0]);
Console.Write(",");
Console.Write(array3[1]);
Console.Write(",");
Console.WriteLine(array3[2]+ "--Third array");

//Line break code
Console.WriteLine();

//Lists the max value in the array and outputs it to the console.
int test = array1.Max();
Console.WriteLine(test + "  Highest value in array1");

int test2 = array2.Max();
Console.WriteLine(test2+ "  Highest value in array2");

int test3 = array3.Max();
Console.WriteLine(test3+ "  Highest value in array3");

//Line break code.
Console.WriteLine();

//Determines how many elements the array contains for each array.
Console.Write(array1.Length+ "  Number of units in array one.");
Console.WriteLine();
Console.Write(array2.Length+ "  Number of units in array two.");
Console.WriteLine();
Console.WriteLine(array3.Length+ "  Number of units in array three.");

//Line break code
Console.WriteLine();

//calculation of putting the highest values in a new array. 
int maxvalue = array1.Max();
Console.WriteLine(maxvalue);

int maxvalue2 = array2.Max();
Console.WriteLine(maxvalue2);

int maxvalue3 = array3.Max();
Console.WriteLine(maxvalue3);

Console.WriteLine();

//Outputs the highest index of each array and outputs into one array and consoleline.
Console.WriteLine("Largest array1 " + maxvalue + " Largest array2 " + maxvalue2 + " Largest array3 " + maxvalue3);



