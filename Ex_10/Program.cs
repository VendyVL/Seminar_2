//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());

string text = num.ToString(); //не пойму как ввести resdLine в формате строки
Console.WriteLine(num + " -> " + text[1]);

int res = (num%100)/10;
Console.WriteLine(num + " -> " + res);