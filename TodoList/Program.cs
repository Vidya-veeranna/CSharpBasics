// See https://aka.ms/new-console-template for more information
var todos = new List<string>();
Console.WriteLine("Hello!");
bool shallExit = false;

while (!shallExit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todos");
    Console.WriteLine("[R]emove a todos");
    Console.WriteLine("[E]xit");
    String userChoice = Console.ReadLine();
    userChoice = userChoice.ToLower();

    switch (userChoice)
    {
        case "s":
            seeAllTODO();
            break;
        case "a":
            addTODO();
            break;
        case "r":
            removeTODO();
            break;
        case "e":
            shallExit= true;
            break;
        default:
            printSelectedChoice("Invalid choice");
            break;
    }

}
Console.ReadKey();
void printSelectedChoice(String selectedChoice)
{
    Console.WriteLine("Selected choice: " + selectedChoice);
}

void seeAllTODO()
{
    if (todos.Count == 0)
    {
        showNoTODOOption();
        return;
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void addTODO()
{
    String description = "";
    do
    {
        Console.WriteLine("Enter the TODO description:");
        description = Console.ReadLine();
    } while (!isDescriptionValid(description));
    todos.Add(description);
    Console.WriteLine("TODO successfully added: " + todos[todos.Count - 1]);
}

bool isDescriptionValid(String description) { 
    if (description == "") {
        Console.WriteLine("Description cannot be empty");
        return false;
    }
    else if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }
    return true;
}

void removeTODO()
{
    if (todos.Count == 0)
    {
        showNoTODOOption();
        return;
    }
   
    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        seeAllTODO();
    } while (!tryRemoveTODO(out index));
    removeTODOItem(index-1);
    
}

bool tryRemoveTODO(out int index)
{
    String userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("index cannot be empty");
        return false;
    }
    if(int.TryParse(userInput,out index) && index>=1 && index<=todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}

void removeTODOItem(int index)
{
    var toBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO Removed: " + toBeRemoved);
}
void showNoTODOOption()
{
    Console.WriteLine("No TODOs have been added yet.");
}

