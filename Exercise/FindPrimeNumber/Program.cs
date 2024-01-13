// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a number:");
string input = Console.ReadLine();
int num = int.Parse(input);

int tempNum = num / 2;
int count = 0;
while (tempNum > 1)
{
    count++;
    if (num % tempNum == 0)
    {
        Console.WriteLine("The given number is not a prime number.");
        return;
    }
    tempNum--;
}

Console.WriteLine("The given number is a Prime number");
Console.WriteLine($"The program made {count} iterations of testing");

