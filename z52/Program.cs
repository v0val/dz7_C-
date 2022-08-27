Console.WriteLine("Введите размерность матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(- 100, 100);
        Console.Write(matrix[i,j]+" ");
        
    }
Console.WriteLine();
}
double summa = 0;
for (int j = 0; j < n; j++)
{
    summa = 0;
    for (int i = 0; i < m; i++)
    {
        summa += matrix[i,j];
    }
Console.Write($"среднее арифметическое элементов в столбце {j} = ");
Console.WriteLine(summa/m);
}