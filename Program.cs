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

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

int SummaNechetnyx(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i = i + 2) summa = summa + array[i];
    return summa;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
int Summa = SummaNechetnyx(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}] - > {Summa}");
