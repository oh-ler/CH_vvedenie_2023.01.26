// Дано число больше 9. Вывести на экран  вторую цифру числа с конца
int a,b;

a=Convert.ToInt32(Console.ReadLine());
b=a%100;
System.Console.WriteLine($"предпоследняя цифра с клавитатуры = {b/10}");

