// По двум заданным числам проверять является ли одно квадратом другого.
int a, b;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());

if (a==b*b || b==a*a)
    System.Console.WriteLine("число= квадрату второго");
    else
        System.Console.WriteLine("число не равно квадрату второго");