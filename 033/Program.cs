// Возведите число А в натуральную степень B используя цикл
int a,b;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
long d=a;
for (int i=1; i<=b; d=d*a, i++)
{
System.Console.WriteLine(d);
}