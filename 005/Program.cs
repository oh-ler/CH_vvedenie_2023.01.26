// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

double a,b,c, max;
System.Console.WriteLine("Введите 3 числа");
a=Convert.ToDouble(Console.ReadLine());
b=Convert.ToDouble(Console.ReadLine());
c=Convert.ToDouble(Console.ReadLine());
max=0;
if (a>max)
    max=a;
if (b>max)
    max=b;
if (c>max)
    max=c;


System.Console.WriteLine($"Max={max}");
