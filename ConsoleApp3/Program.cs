int m = 2;
int n = 3;

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
Console.WriteLine("---------");
int d = 3;
int c = 2;

int[,] arrSecond = new int[d, c];

for (int x = 0; x < d; x++)
{
    for (int y = 0; y < c; y++)
    {
        arrSecond[x, y] = rnd.Next(-5, 6);
        Console.Write($"{arrSecond[x, y]}" + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("---------");

//for (int i = 0; i < arrFirst.GetLength(0); i++)
//{
//    for (int j = 0; j < arrFirst.GetLength(1); j++)
//}

int[,] result = new int[arrFirst.GetLength(0), arrSecond.GetLength(1)];

if (arrFirst.GetLength(1) == arrSecond.GetLength(0))
{
    for (int x = 0; x < arrFirst.GetLength(0); x++)
    {
        for (int y = 0; y < arrSecond.GetLength(1); y++)
        {
            for (int i = 0; i < arrSecond.GetLength(0); i++)
            {
                result[x, y] += arrFirst[x, i] * arrSecond[i, y];
            }
        }
    }
}
else
{
    Console.WriteLine("ERROR");
}

for (int x = 0; x < result.GetLength(0); x++)
{
    for (int y = 0; y < result.GetLength(1); y++)
    {
        Console.Write($"{result[x, y]}" + "\t");
    }
    Console.WriteLine();
}

