// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

int num3 = 0;
for (int i = 1; i <= num1; i++)
{
    num3 = num3 + i;
}

Console.WriteLine($"Сумма всех целых чисел от 1 до {num1} составит {num3}");