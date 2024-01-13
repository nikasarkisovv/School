
int max = int.MinValue, min = int.MaxValue;
var random = new Random();
for (int i = 0; i < 30; i++)
{
    int temp = random.Next(-10, 45);
    if (max < temp)
    {
        max = temp;
    }
    if (min > temp)
    {
        min = temp;
    }
}
Console.WriteLine($"the temprature of the coldest day was {min} and the temprature of the hottest day was {max}");