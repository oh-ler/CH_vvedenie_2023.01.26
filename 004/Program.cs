// 4.По заданному с клавиатуры номеру дня недели вывести его название

int a;
a=Convert.ToInt32(Console.ReadLine());

if (a==1)
{
    Console.WriteLine("пн");
}
if (a==2)
{
    Console.WriteLine("вт");
}
if (a==3)
 {
    Console.WriteLine("ср");
 }
if (a==4)
{
    Console.WriteLine("чт");
}
if (a==5)
{
    Console.WriteLine("пт");
}
if (a==6)

    Console.WriteLine("сб");

if (a==7)

    Console.WriteLine("вс");

if (a>7)

    Console.WriteLine("Введите число от 1 до 7");
