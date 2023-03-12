// 10 to 2

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

int ChangeNumber(int num)
{
    int result = 0;
    int i = 1;
    while (num>0)
    {
        result = i*(num%2) +result;
        num = num/2;
        i= i*10;
    }
    return result;
}

int resultat = Convert.ToInt32(ChangeNumber(number));

Console.WriteLine(resultat);
