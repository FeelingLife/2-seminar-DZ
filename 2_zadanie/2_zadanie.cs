// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string text_number = Console.ReadLine();
int number = Convert.ToInt32(text_number);
if (number > 0 && number < 99)
{
    Console.Write(number);
    Console.Write(" - третьей цифры нет");
}
if (number > 100 && number < 999)
{
    int number100 = number % 10;
    Console.Write(number100);
}
if (number > 1000 && number < 9999)
{
    int number1000 = (number % 100) / 10;
    Console.Write(number1000);
}
if (number > 10000 && number < 99999)
{
    int number10000 = (number % 1000) / 100;
    Console.Write(number10000);
}