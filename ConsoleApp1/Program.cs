int n = 7;
int[,] array = new int[n, n];
Random rnd = new Random();


for (int x = 0; x < n; x++)
{
    for (int y = 0; y < n; y++)
    {
        array[x, y] = rnd.Next(0, 100);
        Console.Write($"{array[x, y]}" + "\t");
    }
    Console.WriteLine();
}

int k = n - 1;

int a;

for (int i = 0; i < n / 2; i++)
{
    for (int j = i; j < k - i; j++)
    {
        a = array[k - j, i];
        array[k - j, i] = array[k - i, k - j];
        array[k - i, k - j] = array[j, k - i];
        array[j, k - i] = array[i, j];
        array[i, j] = a;
        //a = array[i, j];
        //b = array[j, k - i];
        //c = array[k - i, k - j];
        //d = array[k - j, i];

        //array[i, j] = d;
        //array[j, k - i] = a;
        //array[k - i, k - j] = b;
        //array[k - j, i] = c;
    }
}


Console.WriteLine("--------------");
for (int x = 0; x < n; x++)
{
    for (int y = 0; y < n; y++)
    {
        Console.Write($"{array[x, y]}" + "\t"); // ({i}, {j})
    }
    Console.WriteLine();
}
