// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число: ");

int firstnumber = int.Parse(Console.ReadLine());
int secondnumber = int.Parse(Console.ReadLine());

if (firstnumber > secondnumber)
{
Console.WriteLine("{0} наибольшее число", firstnumber);
Console.WriteLine("{0} наименьшее число ", secondnumber);
}
else
{
Console.WriteLine("{0} наибольшее число ", secondnumber);
Console.WriteLine("{0} наименьшее число ", firstnumber);
}