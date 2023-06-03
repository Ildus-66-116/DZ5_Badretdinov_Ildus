// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// int CountChetnye(int[] array)
// {
//     int count = 0;
//     foreach (int element in array)
//     {
//         if (element % 2 == 0)
//             count++;
//     }
//     return count;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Массив: [{string.Join(", ", array)}] - > {CountChetnye(array)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 100);
// }

// int SummaNechetnyx(int[] array)
// {
//     int summa = 0;
//     for (int i = 1; i < array.Length; i = i + 2) summa = summa + array[i];
//     return summa;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// int Summa = SummaNechetnyx(array);
// Console.WriteLine($"Массив: [{string.Join(", ", array)}] - > {Summa}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

// void InputArray(double[] array)
// {
//     int end = 100, begin = 1;
//     for (int i = 0; i < array.Length; i++)
//         array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
// }

// double MaxElement (double[] array)
// {
//     double Max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(Max < array[i]) Max = array[i];
//     }
//     return Max;
// }


// double MinElement (double[] array)
// {
//     double Min = 100;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(Min > array[i]) Min = array[i];
//     }
//     return Min;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n];
// InputArray(array);
// double Max = MaxElement(array);
// double Min = MinElement(array);
// Console.WriteLine($"Массив: [{string.Join(", ", array)}] => {Max} - {Min} = {Max - Min}");

// Дополнительная задача Статистика

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}


int CountNeChetnye(int[] array)
{
    int countNch = 0;
    foreach (int element in array)
    {
        if (element % 2 == 1)
            countNch++;
    }
    return countNch;
}

int CountChetnye(int[] array)
{
    int countCh = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
            countCh++;
    }
    return countCh;
}

int [] InputNeChet(int[] array, int[] resultNech)
{
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1) 
        {
            resultNech[j] =  array[i];
            j = j +1;
        }
    }
    return resultNech;
}

int [] InputChet(int[] array, int[] resultCh)
{
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
        {
            resultCh[j] =  array[i];
            j = j +1;
        }
    }
    return resultCh;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
int oc3 = CountNeChetnye(array);
int oc4 = CountChetnye(array);
int[] resultNech = new int[oc3];
int[] resultCh = new int[oc4];
InputNeChet(array, resultNech);
Console.WriteLine($"Даты когда получил 3: [{string.Join(", ", resultNech)}]");
InputChet(array, resultCh);
Console.WriteLine($"Даты когда получил 4: [{string.Join(", ", resultCh)}]");
if (oc3 < oc4) Console.WriteLine("Yes");
else Console.WriteLine("No");