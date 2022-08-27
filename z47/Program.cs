Console.WriteLine("Введите размерность матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().NextDouble()*100 - 100;
        Console.Write(matrix[i,j]+" ");
    }
Console.WriteLine();
}