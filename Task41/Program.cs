int CountPositive(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Input number of numbers you want to check");
int numbersNumber = Convert.ToInt32(Console.ReadLine());
int counter = CountPositive(numbersNumber);

Console.WriteLine(counter);
