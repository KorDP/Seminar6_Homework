Console.WriteLine("Задайте 4 координаты: ");
Console.Write("b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double[] FindCrossPoint(double b1, double k1, double b2, double k2)
{
    double[] res = new double[2];
    res[0] = (b2 - b1) / (k1 - k2);
    res[1] = k2 * res[0] + b2;
    return res;
}

double[] result = FindCrossPoint(b1, k1, b2, k2);

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); // $"{Math.Round(array[i], 4)}, "
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

PrintArray(result);