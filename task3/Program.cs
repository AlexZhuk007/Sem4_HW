// Задача 3: Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет 
// последним, второй – предпоследним и т.д.)

Console.Clear();

int max = 100;
int min = 0;
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateRandomArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}



void ShowArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item}, ");
    }
}

int[] ChangeArray(int[] array)
{
    int[] newarray = new int [size];
    int temp = 0;
    for (int i = 0; i < size; i++)
    {
        newarray[i] = array[i];
        temp = newarray[i];
        newarray[i] = array[size-1];
        newarray[size-1] = temp;
        size--;
    }
    return newarray;
}

void ShowNewArray(int[] newarray)
{
    foreach (int item in newarray)
    {
        Console.Write($"{item}, ");
    }
}



int[] array = CreateRandomArray(min, max, size);
ShowArray(array);
Console.WriteLine();
int[] newarray = ChangeArray(array);
ShowNewArray(newarray);