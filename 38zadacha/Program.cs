// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[size];
FillArr(arr);
PrintArr(arr);
double max = arr[0];
double min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    else if (arr[i] < min) min = arr[i];
}

void FillArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
                arr[i] = Convert.ToDouble(new Random().Next(100, 100000) / 100.0);
    }
}

void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    continue;
    Console.WriteLine("Ваш массив: " + ("[" + String.Join(", ", arr) + "]"));
}

double diff = max - min;
Console.Write($"Разница между Max-{max} и Min-{min} равна: " + (Math.Round(diff, 2)));