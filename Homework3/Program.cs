// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");

int numbers = int.Parse(Console.ReadLine());

if ((numbers % 2) == 0)
{
    Console.WriteLine("Число {0} является четным ",  numbers);
}
else
{
 Console.WriteLine("Число {0} является нечетным ",  numbers);
}