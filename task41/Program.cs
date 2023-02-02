Console.WriteLine("Сколько чисел вы хотите ввести? ");
int count = Convert.ToInt32(Console.ReadLine());

int IsNumPos(int count_m)
{
    Console.WriteLine("Введите числа: ");
    int posNums = 0;
    int[] arr = new int[count_m];
    for (int i = 0; i < count_m; i++)
    {
        Console.Write($"{i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
        if(arr[i] > 0) posNums++;
    }
    return posNums;
}

int result = IsNumPos(count);
Console.WriteLine($"Вы ввели {result} чисел(числа) больше 0.");