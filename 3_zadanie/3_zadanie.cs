// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
string text_number = Console.ReadLine();
int number = Convert.ToInt32(text_number);
if ((number == 6) || (number == 7))
{
    Console.WriteLine("ВЫХОДНОЙ ДЕНЬ!!!");
}
if((number > 0) && (number < 6))
{
    Console.WriteLine("ОПЯТЬ ТРУДОВЫЕ БУДНИ(((");
}
if ((number <= 0) || (number > 7))
{
    Console.WriteLine("Открой глазки, нужно ввести число от 1 до 7");
}