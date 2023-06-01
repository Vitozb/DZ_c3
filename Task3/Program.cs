void Kub(int N)
{
for (int i = 1; i <= N ; i++)
{
double result = Math.Pow(i,3);
if (i < N) Console.Write(result+",");
else Console.Write(result+".");
}
System.Console.WriteLine();
}

System.Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Kub(N);