// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("Input first Number");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input second Number");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
String userInput = Console.ReadLine();
if (userInput == "A" || userInput == "a")
{
    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
}else if(userInput == "S" || userInput == "s")
{
    Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
}
else if(userInput == "M" || userInput == "m"){
    Console.WriteLine(firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
}
else
{
    Console.WriteLine("Invalid choice");
}
Console.WriteLine("Press any key to exit...");

Console.ReadKey();
