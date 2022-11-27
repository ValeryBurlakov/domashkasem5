// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
int arrayMax = 0;
for (int i = 0; i < array.Length; i++)
{
    int max = i;
    for (int o = i + 1; o < array.Length; o++)
    {
        if (array[o] > array[max])
        {
            max = o;
            
        }
        arrayMax = array[max];
        Console.WriteLine(arrayMax);
    }
}
Console.WriteLine(arrayMax);
