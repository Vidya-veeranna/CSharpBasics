// See https://aka.ms/new-console-template for more information

var ex1 = new optionalParam();
ex1.printOptionalParam();
Console.ReadKey();
class optionalParam
{
    public string Name;
    public int Age;

    public optionalParam(string name="unknown", int age =20)
    {
        Name = name;
        Age = age;
    }
    public void printOptionalParam()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Äge: " + Age);
    }


}


