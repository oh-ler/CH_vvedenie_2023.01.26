//Написать программу вычисления произведения чисел от 1 до N

int n=Convert.ToInt32(Console.ReadLine());
for (int i=1, sum=1; i<=n+1; sum=sum*i, i++)
{
System.Console.WriteLine(sum);
}