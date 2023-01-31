// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int a;

a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Последняя цифра с клавитатуры = {a%10}");
