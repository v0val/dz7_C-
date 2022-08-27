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
Console.WriteLine("Введите позицию элемента матрицы");
int numberString = Convert.ToInt32(Console.ReadLine());
int numberColumn = Convert.ToInt32(Console.ReadLine());
if (numberString >= m 
    || numberColumn >= n 
    || numberString < 0 
    || numberColumn < 0) Console.WriteLine("Такого элемента нет");
else Console.WriteLine(matrix[numberString, numberColumn]);
