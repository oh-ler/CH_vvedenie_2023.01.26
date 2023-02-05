// Программа проверяет пятизначное число на палиндромом. Например:12321

int b,c;
int i=0;
string a=Console.ReadLine();
a=a.Remove(2,1);
//string f=a;
c=Convert.ToInt32(a);
b=Convert.ToInt32(a);
int d=c/10;
int e=c%10;
int f=(c%1000)/10;
if (d==e $$ (f%11==0 || f==0))
    System.Console.WriteLine("палиндром");
    else 
    System.Console.WriteLine("не палиндром");