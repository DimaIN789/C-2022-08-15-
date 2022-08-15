// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
int num3 = 1;
for (num2 = 2; num2 <= num1; num2++)
{
    num3 = num3 * num2;
}
Console.WriteLine($"Произведение чисел от 1 до {num1} составит {num3}");
