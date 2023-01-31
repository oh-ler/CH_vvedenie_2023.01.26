// Вывести на экран числа от -N до N

int n,i,a;

n=Convert.ToInt32(Console.ReadLine());
a=-n;
i=a;
while (i<=n)
    {
        System.Console.WriteLine(i);
        i=i+1;
    }
