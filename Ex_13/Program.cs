// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if ( num < 100 ) Console.WriteLine(num + " -> третьей цифры нет");
else 
{
    string text = num.ToString();
    Console.WriteLine(num + " -> " + text[2]);
}

