// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,1000);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.Write("Ваш массив: ");
Console.WriteLine(string.Join(", ", array));

int count = 0;
int lengthArr = array.Length;
    for (int i = 0; i < lengthArr; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
if (count > 0)
{
Console.WriteLine($"Количество чётных чисел в массиве равно: {count}");
}
if (count == 0)
{
    Console.WriteLine("В массиве нет чётных чисел");
}























// int t = new Random().Next(2, 15);
// int[] array = new int[t]

//     int length = array.Length;
//     int index = 0;
//     while (index < length)
//     {
//         array[index] = new Random().Next(100, 1000);
//         index++;}
    



//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
    
//     int lengthArr = array.Length;
//     for (int i = 0; i < lengthArr; i++)
//     {
//         int count = 0;
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }

//     Console.WriteLine(count);

// int t = new Random().Next(2, 15);
// int[] array = new int[t];




