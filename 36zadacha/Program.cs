// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
    
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,500);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.Write("Ваш массив: ");
Console.WriteLine(string.Join(", ", array));

int sumDigit = 0;
int lengthArr = array.Length;
    for (int i = 0; i < lengthArr; i++)
    {
        if (i % 2 == 1)
        {
            sumDigit = sumDigit + array[i];
            Console.WriteLine($"Индекс: " + string.Join(" ", i) + $" число: {array[i]}");
        }
    }
Console.WriteLine($"Сумма нечётных элементов массива равна: {sumDigit}");