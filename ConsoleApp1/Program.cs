// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Hello, World!");
string myVariable = "This fruit is an apple";
string myVariableTwo = "123";
*/

/*Type dataType = myVariable.GetType();
Console.WriteLine(dataType);
if (dataType == typeof(int))
{
    Console.WriteLine ($"THe variable {myVariable} is an integer.");
}
else
{
    Console.WriteLine ($"The variable {myVariable} is not an integer.");
}*/


/*
if (int.TryParse(myVariableTwo, out int number))
{
    Console.WriteLine($"Conversion successful: {number}");
}
else
{
    Console.WriteLine("Conversion failed");
}
*/

//Counting vowels
Console.WriteLine("Enter a string:");
string inputString = Console.ReadLine();
//Console.WriteLine ("You entered " + inputString);
int vowelCount = 0;
foreach (char c in inputString)
{
    if (c=='a' || c=='e' || c=='i' || c=='o' || c=='u')
    {
        vowelCount++;
    }
}
string message = $"The vowel count in {inputString} is {vowelCount}.";
Console.WriteLine(message);