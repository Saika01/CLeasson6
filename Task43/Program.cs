Console.WriteLine("Input the numbers");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double FindX(double a,double b, double c, double d)
{
    return (c-a)/(b-d);
}

double FindY(double a,double x, double c)
{
    return a*x+c;
}

double resultX = FindX(b1,k1,b2,k2);
double resultY = FindY(k1,resultX,b1);

Console.WriteLine($"The dot is ({resultX};{resultY})");
