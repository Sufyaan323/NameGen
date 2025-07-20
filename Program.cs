static string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? "";
}

static string GetName(int lineNumber)
{
    string? line = null;

    using var reader = new StreamReader("names.txt");

    for (int i = 0; i <= lineNumber; i++)
    {
        line = reader.ReadLine();
    }

    return line!;
}

string name = "";
bool accepted = false;
int quantity = 0;
Random rand = new Random();

while (accepted == false)
{
        try
    {
        string input = Prompt("How many names would you like to generate for the name? ");
        quantity = string.IsNullOrWhiteSpace(input) ? 2 : int.Parse(input);
        accepted = true;
    }
    catch
    {
        Console.WriteLine("Please enter a number.");
    }
}

for (int i = 0; i < quantity; i++)
{
    int num = rand.Next(300);
    name += GetName(num) + " ";
}


Console.WriteLine("Generated name: " + name.Trim());

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();