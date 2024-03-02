// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

//Задача не решена. Я с ней еще работаю. Не получается разобраться с переменной bool. Остальные решены.

Console.Write("Введите любое число или букву q для выхода: ");
int AnySimbol = Convert.ToInt32(Console.ReadLine());
Console.Write(AnySimbol);
Console.WriteLine();


int sum = 0;
while (AnySimbol > 0)
{
    sum = sum + AnySimbol%10;
    AnySimbol=AnySimbol/10;
}
//Console.Write(sum);

if (sum/2 == 0)
{
    Console.Write(sum);
}
else
{
    int AnySimbolToo = Convert.ToInt32(Console.ReadLine());
    AnySimbol = AnySimbolToo;
}




// string flag = "1";
// while (flag != "q")
// {
//     Console.WriteLine("Введите любое число или букву q для выхода: ");
//     flag = Console.ReadLine();
//     int num = Convert.ToInt32(flag);
// }