using System.Globalization;

int n = 8;
int[,] array = new int[n, n];
Random rnd = new Random();

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        array[x, y] = rnd.Next(0, 3);
        Console.Write($"{array[x, y]}" + "\t"); // ({i}, {j})
    }
    Console.WriteLine();
}

int sum = 0;
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        if((i == 0 | i == n - 1) & (j == 0 & j == n - 1))
        {
            sum += array[i, j];
        }
    }
}