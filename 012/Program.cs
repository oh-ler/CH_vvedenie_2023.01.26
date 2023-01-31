// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a,b,c;

a=Convert.ToInt32(Console.ReadLine());
b=a%10;
c=a/10;

if (b>c)
    System.Console.WriteLine($"наибольшее число {b}");
        else 
        System.Console.WriteLine($"наибольшее число {c}");