void Polindrom(int num)
{
int sum = 0;
int i = num;    
if(num>9999 && num<100000)
{
for(i = num; num!=0; num=num/10)
{
int temp=num % 10;
sum = sum*10+temp;
}
if(i==sum)
Console.WriteLine($"{i} Это палиндром");
else
Console.WriteLine($"{i} Это не палиндром");
} else
Console.WriteLine("Вы ввели не пятизначное число ");
}
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Polindrom(num);
