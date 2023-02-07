// Вывести на экран кубы чисел от 1 до N
int n,i;
Int64 c;
n=Convert.ToInt32(Console.ReadLine());
for (i=2,c=1; i<=n+1; c=i*i*i, i=i+1)
{
System.Console.WriteLine(c);
}