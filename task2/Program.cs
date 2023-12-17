// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)

{
    array[i] = new Random().Next();
    Console.Write(array[i] + " ");
    }

int count = 0;

for (int x = 0; x < array.Length; x++)
{
if (array[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {array.Length} чисел, {count} четных");
