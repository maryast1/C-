// // Задайте массив из вещественных чисел с ненулевой дробной частью.
// // Найдите разницу между максимальным и минимальным элементов массива.

Random random = new Random();
double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.NextDouble() * 100;
    Console.WriteLine(array[i].ToString("F3"));
}
// получить минимальный элемент
Console.WriteLine("Smallest  Element: " + array.Min());

// Max() возвращает наибольшее число в массиве
Console.WriteLine("Largest Element: " + array.Max());

double difference = (array.Max() - array.Min());

Console.WriteLine("Разница между максимальным и минимальным элементом:" + difference);