//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.WriteLine("Зададим массив, заполненный положительными трёхзначными числами, выведем его на экран. Укажите колличество чисел в массиве:");
int num = int.Parse(Console.ReadLine()?? "");
int [] array = new int [num];
for (int i = 0; i < num; i++)
{
    array [i] = new Random().Next(100,1000);
    Console.Write($"{array [i]}  ");
}
int sumOdd = 0;
int sumEven = 0;
for (int i = 0; i < 12; i++)
{
    if (array [i] % 2 == 0) sumEven = sumEven + array [i];
    if (array [i] % 2 > 0) sumOdd = sumOdd + array [i];
}
Console.WriteLine();
Console.WriteLine($"Сумма четных элементов массива = {sumEven}");
Console.WriteLine($"Сумма нечетных элементов массива = {sumOdd}");
