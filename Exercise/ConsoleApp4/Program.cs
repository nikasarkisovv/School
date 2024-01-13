Console.WriteLine("Please enter a number between 1 to 9");
string input = Console.ReadLine();

int num = int.Parse(input);

for (int y = 1; y <= num; y++)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int y = 1; y <= num; y++)
{
    for (int i = num; i >= 1; i--)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int y = 1; y <= num; y++)
{
    for (int i = 1; i <= y; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int y = 1; y <= num; y++)
{
    for (int i = y; i >= 1; i--)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int y = 1; y <= num; y++)
{
    if (y % 2 == 1)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " ");
        }
    }
    else
    {
        for (int i = num; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
    }

    Console.WriteLine();
}