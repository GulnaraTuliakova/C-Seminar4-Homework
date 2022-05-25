//Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
Console.WriteLine("Зададим массив из 12 элементов, заполненных числами [-9,9], выведем его на экран");
int [] array = new int [12];
for (int i = 0; i < 12; i++)
{
    array [i] = new Random().Next(-9,10);
    Console.Write($"{array [i]}  ");
}
int sumMin = 0;
int sumMax = 0;
for (int i = 0; i < 12; i++)
{
    if (array [i] < 0) sumMin = sumMin + array [i];
    if (array [i] > 0) sumMax = sumMax + array [i];
}
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов массива = {sumMin}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sumMax}");
