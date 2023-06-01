void Distance(int[] A,int[] B)
{
double dist = Math.Sqrt(Math.Pow(B[0] - A[0],2) + Math.Pow(B[1] - A[1],2) + Math.Pow(B[2] - A[2],2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {dist}");    
}


int[] A = new int[3];
int[] B = new int[3];
System.Console.WriteLine("Введите координаты первой точки");
for (int i = 0; i < A.Length; i++)
{
    A[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("Введите координаты второй точки");
for (int i = 0; i < B.Length; i++)
{
    B[i] = Convert.ToInt32(Console.ReadLine());
}
Distance(A,B);

