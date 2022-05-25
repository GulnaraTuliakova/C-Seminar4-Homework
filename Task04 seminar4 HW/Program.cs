//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.WriteLine("В одномерном массиве из 123 чисел найдем количество элементов из отрезка [10,99]");
int [] array = new int [123];
for (int i = 0; i < 123; i++)
{
    array [i] = new Random().Next(0,1000);
    Console.Write($"{array [i]}  ");
}
int count = 0;
for (int i = 0; i < 123; i++)
{
    if (array [i] >= 10 && array [i] <= 99 ) count = count + 1;
}
Console.WriteLine();
Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");
