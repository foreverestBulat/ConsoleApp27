using System.Globalization;

int[,] array = new int[5, 5];
Random rnd = new Random();

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        array[x, y] = rnd.Next(0, 100);
        Console.Write($"{array[x, y]}" + "\t"); // ({i}, {j})
    }
    Console.WriteLine();
}
//int k = 4;
//int i = 0;
//int j = 2;

//int n = 5;

//int a = array[i, j];
//Console.WriteLine(a);

//int b = array[i, k - j];
//Console.WriteLine(b);

//int c = array[k - i, k - j];
//Console.WriteLine(c);

//int d = array[k - i, j];
//Console.WriteLine(d);


//array[i, j] = d;
//array[i, k - j] = a;
//array[k - i, k - j] = b;
//array[k - i, j] = c;
int n = 5;
int k = n - 2;
int f = 0;

for (int i = 0; i < n / 2; i++)
{

    for (int j = f; i < f & f < k; j++)
    {
        Console.WriteLine(array[i, j]);
    }
    f++;
    k--;
}

        //int n = 5;
        //int f = 0;
        //int a, b, c, d;
        //int k = n - 2;


        //for (int i = 0; i < n / 2; i++)
        //{

        //    for (int j = f; i < f & f < k; j++)
        //    {
        //        a = array[i, j];
        //        b = array[j, k - i];
        //        c = array[k - i, k - j];
        //        d = array[k - j, i];

        //        array[i, j] = d;
        //        array[j, k - i] = a;
        //        array[k - i, k - j] = b;
        //        array[k - j, i] = c;
        //    }
        //    f++;
        //    k--;

        //}

        //for (int i = 0; i < n / 2; i++)
        //{
        //    //while ((k != 1) | (l))
        //    for (int j = f; k - 1 > j; j++)
        //    {
        //        a = array[i, j];
        //        Console.Write(a);
        //        b = array[i, n - 1 - j];
        //        c = array[n - 1 - i, n - 1 - j];
        //        d = array[n - 1 - i, j];

        //        array[i, j] = d;
        //        array[i, n - 1 - j] = a;
        //        array[n - 1 - i, n - 1 - j] = b;
        //        array[n - 1 - i, j] = c;

        //    }
        //    Console.WriteLine();
        //    f++;

        //    k--;
        //}


Console.WriteLine("--------------");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{array[i, j]}" + "\t"); // ({i}, {j})
    }
    Console.WriteLine();
}

//int a, b, c, d;
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        a = array[i, j];

//    }
//}


//for (int i = 0; i < 5; i++)
//{
//    array[i] = rnd.Next(0, 100);
//    Console.Write(array[i] + "\t");
//}

//Array.Resize(ref array, array.Length + 1);