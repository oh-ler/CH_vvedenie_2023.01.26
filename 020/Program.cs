// Дано число. Проверить кратно ли оно 7 и 23

int a;

a=Convert.ToInt32(Console.ReadLine());

if (a%7==0 && a%23==0)
    System.Console.WriteLine("кратно");
    else 
        System.Console.WriteLine("не кратно");