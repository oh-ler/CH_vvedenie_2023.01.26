// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

int a,b,c;
a=Convert.ToInt32(Console.ReadLine);
if (a.remove(3,1))
    System.Console.WriteLine(a);

