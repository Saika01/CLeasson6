// Каждая сторона треугольника меньше 2х других

Console.WriteLine("Input 1st number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2nd number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 3rd number");
int c = Convert.ToInt32(Console.ReadLine());

bool IfTriangleExists(int one, int two, int three)
{
    return one+two>three && two+three>one && three+one>two;
}

if(IfTriangleExists(a,b,c)) Console.WriteLine("Yes");
else Console.WriteLine("No");
