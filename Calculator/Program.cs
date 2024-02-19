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
userInput=userInput.ToUpper();
if (userInput == "A")
{
    int result = firstNumber + secondNumber;
    printResult(firstNumber, secondNumber, result, " + ");
}else if(userInput == "S")
{
    int result = firstNumber - secondNumber;
    printResult(firstNumber, secondNumber, result, " - ");
}
else if(userInput == "M"){
    int result = firstNumber * secondNumber;
    printResult(firstNumber, secondNumber, result, " * ");
}
else
{
    Console.WriteLine("Invalid choice");
}
Console.WriteLine("Press any key to exit...");

Console.ReadKey();

void printResult(int num1, int num2, int result, String @operator)
{
    Console.WriteLine($"{num1}{@operator}{num2} = {result}");
}