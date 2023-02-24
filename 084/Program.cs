//84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа
string c=Console.ReadLine();
char [] a = c.ToCharArray();
foreach (char b in a);
int i=0;
int qw=0;
//var number = int.Parse(c);
//int [] a=new int [c.Length];
if(i<a.Length)
{
    qw+=c[i];
    i++;
}
else 
{
    System.Console.WriteLine("введите целое число");
}
 System.Console.WriteLine(qw);