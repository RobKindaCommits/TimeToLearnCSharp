// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string myVariable = "This fruit is an apple";
Type dataType = myVariable.GetType();
Console.WriteLine(dataType);
if (dataType == typeof(int))
{
    Console.WriteLine ($"THe variable {myVariable} is an integer.");
}
else
{
    Console.WriteLine ($"The variable {myVariable} is not an integer.");
}