int m = 7;
int n = 6;

int[,] arrFirst = new int[m, n];
Random rnd = new Random();


for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        arrFirst[x, y] = rnd.Next(-5, 6);
        Console.Write($"{arrFirst[x, y]}" + "\t");
    }
    Console.WriteLine();
}

//int a = 3;
//int b = a + 1;
int a;
for (int i = 0; i < arrFirst.GetLength(0); i++)
{
    if ((i != arrFirst.GetLength(0) - 1) && i % 2 == 0)
    {
        for (int j = 0; j < arrFirst.GetLength(1); j++)
        {
            a = arrFirst[i, j];
            arrFirst[i, j] = arrFirst[i + 1, j];
            arrFirst[i + 1, j] = a;
        }
    }
}

Console.WriteLine("--------------------");

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        Console.Write($"{arrFirst[x, y]}" + "\t");
    }
    Console.WriteLine();
}