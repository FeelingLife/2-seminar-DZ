//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
string text_number = Console.ReadLine();
int number = Convert.ToInt32(text_number);
int result = (number / 10) % 10;
Console.WriteLine(result);