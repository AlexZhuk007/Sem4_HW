// Задача 2: Задайте массив заполненный случайными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в 
// массиве.

Console.Clear();
int[] CreateRandomArray(int min, int max, int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(min, max + 1);
  }
  return array;
}

int max = 1000;
int min = 100;
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int CountEvenDig(int[] array)
{
  int sum = 0;
  foreach (int i in array)
  {
    if (i % 2 == 0)
    {
      sum++;
    }
  }
  return sum;
}
void ShowArray(int [] array){
    foreach (int item in array)
    {
        Console.Write($"{item}, ");
    }
}
void ShowCountEvenDig(int sum)
{
  Console.WriteLine($"Количество четных цифр в массиве равно {sum}");
}

int[] array = CreateRandomArray(min, max, size);
ShowArray(array);
int sum = CountEvenDig(array);
ShowCountEvenDig(sum);
