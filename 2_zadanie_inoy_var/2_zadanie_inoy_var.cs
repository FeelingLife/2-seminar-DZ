Console.WriteLine("Введите число: ");
string text_number = Console.ReadLine();
int number = Convert.ToInt32(text_number);
int result = number;
int count = 0;

number = Math.Abs(number);
if (number < 100) 
{
    Console.Write(number);
    Console.Write(" - в числе нет 3-ей цифры");
}
else
{
    while(number > 999)
    {
        number = number / 10;
    }
    Console.Write("Третья цифра в этом числе: ");
    Console.WriteLine(number % 10);
}