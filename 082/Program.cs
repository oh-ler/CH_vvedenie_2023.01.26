// C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
string c=Console.ReadLine();
int i=0;
while (c[i]!='.')
{
  i++;
}
System.Console.WriteLine(i);