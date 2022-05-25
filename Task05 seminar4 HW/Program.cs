//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Найдем произведение пар чисел в одномерном массиве. Введите количество чисел в массиве:");
int num = int.Parse(Console.ReadLine()?? "");
int [] array = new int [num];
for (int i = 0; i < num; i++)
{
    array [i] = new Random().Next(-100,100);
    Console.WriteLine($"{array [i]}  ");
}
int prod = -1;

for (int i = 0; i < num/2; i++)
{
    prod = array [i] * array [num-1-i];
    Console.WriteLine($"{array [i]} * {array [num-1-i]} = {prod}");
}
